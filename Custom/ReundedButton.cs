using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Fotolva.Custom
{
    public class ReundedButton : Button
    {
        private int borderSize = 0;
        private int _borderRadius = 40;
        private Color borderColor = Color.FromArgb(169, 143, 118);

        public int BorderSize { get => borderSize; set { 
                borderSize = value; this.Invalidate(); 
            } }
        public int BorderRadius { get => _borderRadius; set { 
                _borderRadius = value; this.Invalidate(); 
            } }
        public Color BorderColor { get => borderColor; set {
                borderColor = value;
                this.Invalidate();
            } }

        // Constructor de la clase
        public ReundedButton()
        {
            // Establecer el estilo del botón a plano
            this.FlatStyle = FlatStyle.Flat;
            // Establecer el grosor del borde a cero
            this.FlatAppearance.BorderSize = 0;
            // Establecer el color de fondo a transparente
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
        }

        // Método para dibujar el botón con bordes redondeados
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            // Crear un objeto GraphicsPath para dibujar el borde redondeado
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            // Añadir un arco en cada esquina del rectángulo con el radio de borde especificado
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width -  radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            // Cerrar el camino
            path.CloseAllFigures();

            return path;            
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0,0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1,1,this.Width-0.8F,this.Height-1);

            if (_borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, _borderRadius))
                using (GraphicsPath parhBorder = GetFigurePath(rectBorder, _borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, parhBorder);
                    }
                    
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
                
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChange);
        }

        private void Container_BackColorChange(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }
    }
}
