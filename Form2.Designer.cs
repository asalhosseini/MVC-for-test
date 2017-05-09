namespace n_layer_course.UI
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcourseid = new System.Windows.Forms.TextBox();
            this.txthour = new System.Windows.Forms.TextBox();
            this.txtteachername = new System.Windows.Forms.TextBox();
            this.txtbranchid = new System.Windows.Forms.TextBox();
            this.txtcoursename = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ": .کد درس";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ": ساعات کلاسی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = ": نام استاد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = ": کد رشته";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = ": نام درس";
            // 
            // txtcourseid
            // 
            this.txtcourseid.Location = new System.Drawing.Point(495, 25);
            this.txtcourseid.Name = "txtcourseid";
            this.txtcourseid.Size = new System.Drawing.Size(154, 20);
            this.txtcourseid.TabIndex = 5;
            // 
            // txthour
            // 
            this.txthour.Location = new System.Drawing.Point(495, 285);
            this.txthour.Name = "txthour";
            this.txthour.Size = new System.Drawing.Size(154, 20);
            this.txthour.TabIndex = 6;
            // 
            // txtteachername
            // 
            this.txtteachername.Location = new System.Drawing.Point(495, 222);
            this.txtteachername.Name = "txtteachername";
            this.txtteachername.Size = new System.Drawing.Size(154, 20);
            this.txtteachername.TabIndex = 7;
            // 
            // txtbranchid
            // 
            this.txtbranchid.Location = new System.Drawing.Point(495, 168);
            this.txtbranchid.Name = "txtbranchid";
            this.txtbranchid.Size = new System.Drawing.Size(154, 20);
            this.txtbranchid.TabIndex = 8;
            // 
            // txtcoursename
            // 
            this.txtcoursename.Location = new System.Drawing.Point(495, 100);
            this.txtcoursename.Name = "txtcoursename";
            this.txtcoursename.Size = new System.Drawing.Size(154, 20);
            this.txtcoursename.TabIndex = 9;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(695, 378);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(88, 36);
            this.insert.TabIndex = 10;
            this.insert.Text = "اضافه";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(550, 378);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(88, 36);
            this.delete.TabIndex = 11;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(413, 378);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(88, 36);
            this.update.TabIndex = 12;
            this.update.Text = "ویرایش";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 509);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.txtcoursename);
            this.Controls.Add(this.txtbranchid);
            this.Controls.Add(this.txtteachername);
            this.Controls.Add(this.txthour);
            this.Controls.Add(this.txtcourseid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "دروس";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcourseid;
        private System.Windows.Forms.TextBox txthour;
        private System.Windows.Forms.TextBox txtteachername;
        private System.Windows.Forms.TextBox txtbranchid;
        private System.Windows.Forms.TextBox txtcoursename;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
    }
}