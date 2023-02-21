using System;
using System.Windows.Forms;
using System.Drawing;


namespace VolVeRBuilder
{

    class CheckBoxEx : CheckBox
    {



        bool down = false;
        protected override void OnMouseClick(MouseEventArgs e)
        {
            this.OnClick(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {

            if (!Checked)

                if (mevent.Button == MouseButtons.Left)
                {
                    down = true;

                    Invalidate();
                }

        }
        protected override void OnMouseEnter(EventArgs eventargs)
        {

        }
        protected override void OnMouseLeave(EventArgs eventargs)
        {

        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {


            if (mevent.Button == MouseButtons.Left)
            {
                down = false;
                Invalidate();
                OnMouseClick(mevent);
            }

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            FlatAppearance.BorderSize = 0;
            base.OnPaint(e);
            if (Appearance == Appearance.Button)
            {
                if (FlatStyle == FlatStyle.Flat)
                {
                    var Shadowcolor = SystemColors.ButtonShadow;
                    var ShadowWidth = 20;
                    if (!down)
                    {


                        if (this.CheckState == CheckState.Unchecked)
                        {

                            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                          Shadowcolor, ShadowWidth, ButtonBorderStyle.Outset,
                           Shadowcolor, ShadowWidth, ButtonBorderStyle.Outset,
                           Shadowcolor, ShadowWidth + 1, ButtonBorderStyle.Outset,
                         Shadowcolor, ShadowWidth + 1, ButtonBorderStyle.Outset);
                            return;

                        }
                        else

                            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                     Shadowcolor, ShadowWidth + 1, ButtonBorderStyle.Inset,
                     Shadowcolor, ShadowWidth + 1, ButtonBorderStyle.Inset,
                     Shadowcolor, ShadowWidth, ButtonBorderStyle.Inset,
                     Shadowcolor, ShadowWidth, ButtonBorderStyle.Inset);
                        return;

                    }
                    else
                    {




                        ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                   Shadowcolor, ShadowWidth, ButtonBorderStyle.Inset,
                   Shadowcolor, ShadowWidth, ButtonBorderStyle.Inset,
                   Shadowcolor, ShadowWidth, ButtonBorderStyle.Inset,
                   Shadowcolor, ShadowWidth, ButtonBorderStyle.Inset);

                        return;

                    }

                }
            }
        }



    }
}
