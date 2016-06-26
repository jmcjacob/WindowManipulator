namespace WindowManipulator
{
    partial class mainWindow
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
            this.windowList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maximise = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.resize = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // windowList
            // 
            this.windowList.AllowDrop = true;
            this.windowList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.windowList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowList.FormattingEnabled = true;
            this.windowList.Location = new System.Drawing.Point(12, 45);
            this.windowList.Name = "windowList";
            this.windowList.Size = new System.Drawing.Size(323, 26);
            this.windowList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Running Application:";
            // 
            // maximise
            // 
            this.maximise.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximise.Location = new System.Drawing.Point(234, 77);
            this.maximise.Name = "maximise";
            this.maximise.Size = new System.Drawing.Size(102, 26);
            this.maximise.TabIndex = 2;
            this.maximise.Text = "Maximise";
            this.maximise.UseVisualStyleBackColor = true;
            this.maximise.Click += new System.EventHandler(this.maximizeButton);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(234, 142);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(102, 26);
            this.close.TabIndex = 3;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.closeButton);
            // 
            // minimize
            // 
            this.minimize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.Location = new System.Drawing.Point(234, 110);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(102, 26);
            this.minimize.TabIndex = 4;
            this.minimize.Text = "Minimize";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimizeButton);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(215, 12);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(120, 26);
            this.update.TabIndex = 5;
            this.update.Text = "Update List";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.updateButton);
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(12, 77);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(51, 26);
            this.width.TabIndex = 6;
            this.width.Text = "Width";
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(69, 77);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(51, 26);
            this.height.TabIndex = 7;
            this.height.Text = "Height";
            // 
            // x
            // 
            this.x.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(12, 109);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(51, 26);
            this.x.TabIndex = 8;
            this.x.Text = "X";
            // 
            // y
            // 
            this.y.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.Location = new System.Drawing.Point(69, 110);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(51, 26);
            this.y.TabIndex = 9;
            this.y.Text = "Y";
            // 
            // resize
            // 
            this.resize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resize.Location = new System.Drawing.Point(126, 77);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(102, 26);
            this.resize.TabIndex = 10;
            this.resize.Text = "Resize";
            this.resize.UseVisualStyleBackColor = true;
            this.resize.Click += new System.EventHandler(this.resizeButton);
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(126, 110);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(102, 26);
            this.position.TabIndex = 11;
            this.position.Text = "Position";
            this.position.UseVisualStyleBackColor = true;
            this.position.Click += new System.EventHandler(this.positionButton);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Created by Jacob Carse";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 175);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.position);
            this.Controls.Add(this.resize);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.update);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.maximise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windowList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.ShowIcon = false;
            this.Text = "Window Manipulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox windowList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button maximise;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.Button resize;
        private System.Windows.Forms.Button position;
        private System.Windows.Forms.Label label2;
    }
}

