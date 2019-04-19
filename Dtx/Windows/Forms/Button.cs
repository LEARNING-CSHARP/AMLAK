namespace Dtx.Windows.Forms
{
	public class Button : System.Windows.Forms.Button
	{
		public Button() : base()
		{
			BackColor = System.Drawing.Color.LightGray;
			HoverBackColor = System.Drawing.Color.Yellow;
		}

		[System.ComponentModel.DefaultValue(type: typeof(System.Drawing.Color), value: "LightGray")]
		public override System.Drawing.Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
			}
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
