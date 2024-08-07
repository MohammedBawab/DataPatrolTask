namespace RandomNumberApp
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_API = new System.Windows.Forms.Label();
            this.tb_APIURL = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Unregister = new System.Windows.Forms.Button();
            this.lv_Listeners = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Target = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Counter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbl_API
            // 
            this.lbl_API.AutoSize = true;
            this.lbl_API.Location = new System.Drawing.Point(12, 34);
            this.lbl_API.Name = "lbl_API";
            this.lbl_API.Size = new System.Drawing.Size(64, 16);
            this.lbl_API.TabIndex = 0;
            this.lbl_API.Text = "API URL :";
            // 
            // tb_APIURL
            // 
            this.tb_APIURL.Location = new System.Drawing.Point(82, 31);
            this.tb_APIURL.Multiline = true;
            this.tb_APIURL.Name = "tb_APIURL";
            this.tb_APIURL.Size = new System.Drawing.Size(674, 22);
            this.tb_APIURL.TabIndex = 1;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(82, 59);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(163, 59);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(672, 88);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(84, 28);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Unregister
            // 
            this.btn_Unregister.Location = new System.Drawing.Point(672, 122);
            this.btn_Unregister.Name = "btn_Unregister";
            this.btn_Unregister.Size = new System.Drawing.Size(84, 32);
            this.btn_Unregister.TabIndex = 6;
            this.btn_Unregister.Text = "Unregister";
            this.btn_Unregister.UseVisualStyleBackColor = true;
            this.btn_Unregister.Click += new System.EventHandler(this.btn_Unregister_Click);
            // 
            // lv_Listeners
            // 
            this.lv_Listeners.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Name,
            this.Target,
            this.Counter});
            this.lv_Listeners.HideSelection = false;
            this.lv_Listeners.Location = new System.Drawing.Point(15, 88);
            this.lv_Listeners.Name = "lv_Listeners";
            this.lv_Listeners.Size = new System.Drawing.Size(651, 265);
            this.lv_Listeners.TabIndex = 4;
            this.lv_Listeners.UseCompatibleStateImageBehavior = false;
            this.lv_Listeners.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Name
            // 
            this.Name.Text = "Name";
            // 
            // Target
            // 
            this.Target.Text = "Target";
            // 
            // Counter
            // 
            this.Counter.Text = "Counter";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 365);
            this.Controls.Add(this.btn_Unregister);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.lv_Listeners);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.tb_APIURL);
            this.Controls.Add(this.lbl_API);
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_API;
        private System.Windows.Forms.TextBox tb_APIURL;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Unregister;
        private System.Windows.Forms.ListView lv_Listeners;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Target;
        private System.Windows.Forms.ColumnHeader Counter;
    }
}

