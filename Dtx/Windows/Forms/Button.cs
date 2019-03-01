namespace Dtx.Windows.Forms
{
	public class Button : System.Windows.Forms.Button
	{
		public Button() : base()
		{
			HoverBackColor = System.Drawing.Color.Yellow;
		}

		[System.ComponentModel.DefaultValue(type: typeof(System.Drawing.Color), value: "Yellow")]
		public System.Drawing.Color HoverBackColor { get; set; }

		protected System.Drawing.Color CurrentBackColor { get; set; }

		protected override void OnMouseEnter(System.EventArgs e)
		{
			base.OnMouseEnter(e);

			//BackColor = System.Drawing.Color.Yellow;

			//CurrentBackColor = BackColor;
			//BackColor = System.Drawing.Color.Yellow;

			CurrentBackColor = BackColor;
			BackColor = HoverBackColor;
		}

		protected override void OnMouseLeave(System.EventArgs e)
		{
			base.OnMouseLeave(e);

			//BackColor = System.Drawing.SystemColors.Control;

			BackColor = CurrentBackColor;
		}
	}
}
