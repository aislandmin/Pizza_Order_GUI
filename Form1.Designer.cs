namespace PizzaGUI
{
    partial class frmApp
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
            this.tabPageAllOrders = new System.Windows.Forms.TabPage();
            this.dgvPizza = new System.Windows.Forms.DataGridView();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.btnXLarge = new System.Windows.Forms.Button();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.lblLastOrderTime = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkAnchovy = new System.Windows.Forms.CheckBox();
            this.chkBellPepper = new System.Windows.Forms.CheckBox();
            this.chkBlackOlive = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkHotPepper = new System.Windows.Forms.CheckBox();
            this.chkGreenOlive = new System.Windows.Forms.CheckBox();
            this.chkPaneer = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.lstPizzaSize = new System.Windows.Forms.ListBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.tctlOrders = new System.Windows.Forms.TabControl();
            this.tabPageAllOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizza)).BeginInit();
            this.tabPageOrder.SuspendLayout();
            this.tctlOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageAllOrders
            // 
            this.tabPageAllOrders.Controls.Add(this.dgvPizza);
            this.tabPageAllOrders.Controls.Add(this.btnAll);
            this.tabPageAllOrders.Controls.Add(this.btnSmall);
            this.tabPageAllOrders.Controls.Add(this.btnMedium);
            this.tabPageAllOrders.Controls.Add(this.btnLarge);
            this.tabPageAllOrders.Controls.Add(this.btnXLarge);
            this.tabPageAllOrders.Location = new System.Drawing.Point(4, 25);
            this.tabPageAllOrders.Name = "tabPageAllOrders";
            this.tabPageAllOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllOrders.Size = new System.Drawing.Size(1025, 406);
            this.tabPageAllOrders.TabIndex = 1;
            this.tabPageAllOrders.Text = "All Orders";
            this.tabPageAllOrders.UseVisualStyleBackColor = true;
            // 
            // dgvPizza
            // 
            this.dgvPizza.AllowUserToOrderColumns = true;
            this.dgvPizza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPizza.Location = new System.Drawing.Point(210, 19);
            this.dgvPizza.Name = "dgvPizza";
            this.dgvPizza.RowHeadersWidth = 51;
            this.dgvPizza.RowTemplate.Height = 24;
            this.dgvPizza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPizza.Size = new System.Drawing.Size(829, 374);
            this.dgvPizza.TabIndex = 5;
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(59, 306);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(114, 37);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmall.Location = new System.Drawing.Point(59, 246);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(114, 37);
            this.btnSmall.TabIndex = 3;
            this.btnSmall.Text = "Small";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(59, 185);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(114, 37);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLarge.Location = new System.Drawing.Point(59, 127);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(114, 37);
            this.btnLarge.TabIndex = 1;
            this.btnLarge.Text = "Large";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // btnXLarge
            // 
            this.btnXLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXLarge.Location = new System.Drawing.Point(62, 68);
            this.btnXLarge.Name = "btnXLarge";
            this.btnXLarge.Size = new System.Drawing.Size(114, 37);
            this.btnXLarge.TabIndex = 0;
            this.btnXLarge.Text = "X Large";
            this.btnXLarge.UseVisualStyleBackColor = true;
            this.btnXLarge.Click += new System.EventHandler(this.btnXLarge_Click);
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.lblLastOrderTime);
            this.tabPageOrder.Controls.Add(this.btnCancel);
            this.tabPageOrder.Controls.Add(this.btnConfirm);
            this.tabPageOrder.Controls.Add(this.chkMushroom);
            this.tabPageOrder.Controls.Add(this.chkAnchovy);
            this.tabPageOrder.Controls.Add(this.chkBellPepper);
            this.tabPageOrder.Controls.Add(this.chkBlackOlive);
            this.tabPageOrder.Controls.Add(this.chkHam);
            this.tabPageOrder.Controls.Add(this.chkChicken);
            this.tabPageOrder.Controls.Add(this.chkHotPepper);
            this.tabPageOrder.Controls.Add(this.chkGreenOlive);
            this.tabPageOrder.Controls.Add(this.chkPaneer);
            this.tabPageOrder.Controls.Add(this.chkBacon);
            this.tabPageOrder.Controls.Add(this.chkPineapple);
            this.tabPageOrder.Controls.Add(this.chkCheese);
            this.tabPageOrder.Controls.Add(this.lstPizzaSize);
            this.tabPageOrder.Controls.Add(this.lblToppings);
            this.tabPageOrder.Controls.Add(this.lblSize);
            this.tabPageOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrder.Size = new System.Drawing.Size(1025, 406);
            this.tabPageOrder.TabIndex = 0;
            this.tabPageOrder.Text = "Order";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // lblLastOrderTime
            // 
            this.lblLastOrderTime.AutoSize = true;
            this.lblLastOrderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastOrderTime.Location = new System.Drawing.Point(518, 332);
            this.lblLastOrderTime.Name = "lblLastOrderTime";
            this.lblLastOrderTime.Size = new System.Drawing.Size(132, 20);
            this.lblLastOrderTime.TabIndex = 18;
            this.lblLastOrderTime.Text = "Last Order Time";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(347, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(145, 324);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 36);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushroom.Location = new System.Drawing.Point(638, 201);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(110, 24);
            this.chkMushroom.TabIndex = 14;
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            // 
            // chkAnchovy
            // 
            this.chkAnchovy.AutoSize = true;
            this.chkAnchovy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnchovy.Location = new System.Drawing.Point(638, 160);
            this.chkAnchovy.Name = "chkAnchovy";
            this.chkAnchovy.Size = new System.Drawing.Size(94, 24);
            this.chkAnchovy.TabIndex = 13;
            this.chkAnchovy.Text = "Anchovy";
            this.chkAnchovy.UseVisualStyleBackColor = true;
            // 
            // chkBellPepper
            // 
            this.chkBellPepper.AutoSize = true;
            this.chkBellPepper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBellPepper.Location = new System.Drawing.Point(638, 120);
            this.chkBellPepper.Name = "chkBellPepper";
            this.chkBellPepper.Size = new System.Drawing.Size(118, 24);
            this.chkBellPepper.TabIndex = 12;
            this.chkBellPepper.Text = "Bell Pepper";
            this.chkBellPepper.UseVisualStyleBackColor = true;
            // 
            // chkBlackOlive
            // 
            this.chkBlackOlive.AutoSize = true;
            this.chkBlackOlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlackOlive.Location = new System.Drawing.Point(638, 80);
            this.chkBlackOlive.Name = "chkBlackOlive";
            this.chkBlackOlive.Size = new System.Drawing.Size(116, 24);
            this.chkBlackOlive.TabIndex = 11;
            this.chkBlackOlive.Text = "Black Olive";
            this.chkBlackOlive.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHam.Location = new System.Drawing.Point(510, 200);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(67, 24);
            this.chkHam.TabIndex = 10;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChicken.Location = new System.Drawing.Point(510, 159);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(91, 24);
            this.chkChicken.TabIndex = 9;
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            // 
            // chkHotPepper
            // 
            this.chkHotPepper.AutoSize = true;
            this.chkHotPepper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHotPepper.Location = new System.Drawing.Point(510, 119);
            this.chkHotPepper.Name = "chkHotPepper";
            this.chkHotPepper.Size = new System.Drawing.Size(116, 24);
            this.chkHotPepper.TabIndex = 8;
            this.chkHotPepper.Text = "Hot Pepper";
            this.chkHotPepper.UseVisualStyleBackColor = true;
            // 
            // chkGreenOlive
            // 
            this.chkGreenOlive.AutoSize = true;
            this.chkGreenOlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenOlive.Location = new System.Drawing.Point(510, 79);
            this.chkGreenOlive.Name = "chkGreenOlive";
            this.chkGreenOlive.Size = new System.Drawing.Size(120, 24);
            this.chkGreenOlive.TabIndex = 7;
            this.chkGreenOlive.Text = "Green Olive";
            this.chkGreenOlive.ThreeState = true;
            this.chkGreenOlive.UseVisualStyleBackColor = true;
            // 
            // chkPaneer
            // 
            this.chkPaneer.AutoSize = true;
            this.chkPaneer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaneer.Location = new System.Drawing.Point(375, 200);
            this.chkPaneer.Name = "chkPaneer";
            this.chkPaneer.Size = new System.Drawing.Size(84, 24);
            this.chkPaneer.TabIndex = 6;
            this.chkPaneer.Text = "Paneer";
            this.chkPaneer.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBacon.Location = new System.Drawing.Point(375, 159);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(79, 24);
            this.chkBacon.TabIndex = 5;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPineapple.Location = new System.Drawing.Point(375, 119);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(104, 24);
            this.chkPineapple.TabIndex = 4;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheese.Location = new System.Drawing.Point(375, 79);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(88, 24);
            this.chkCheese.TabIndex = 3;
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // lstPizzaSize
            // 
            this.lstPizzaSize.FormattingEnabled = true;
            this.lstPizzaSize.ItemHeight = 16;
            this.lstPizzaSize.Location = new System.Drawing.Point(32, 73);
            this.lstPizzaSize.Name = "lstPizzaSize";
            this.lstPizzaSize.Size = new System.Drawing.Size(291, 180);
            this.lstPizzaSize.TabIndex = 2;
            this.lstPizzaSize.SelectedIndexChanged += new System.EventHandler(this.lstPizzaSize_SelectedIndexChanged);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(371, 30);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(77, 20);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Toppings";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(31, 33);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(42, 20);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size";
            // 
            // tctlOrders
            // 
            this.tctlOrders.Controls.Add(this.tabPageOrder);
            this.tctlOrders.Controls.Add(this.tabPageAllOrders);
            this.tctlOrders.Location = new System.Drawing.Point(2, 13);
            this.tctlOrders.Name = "tctlOrders";
            this.tctlOrders.SelectedIndex = 0;
            this.tctlOrders.Size = new System.Drawing.Size(1033, 435);
            this.tctlOrders.TabIndex = 0;
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 450);
            this.Controls.Add(this.tctlOrders);
            this.Name = "frmApp";
            this.Text = "Xiaomin\'s Pizza Emporium";
            this.tabPageAllOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizza)).EndInit();
            this.tabPageOrder.ResumeLayout(false);
            this.tabPageOrder.PerformLayout();
            this.tctlOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageAllOrders;
        private System.Windows.Forms.DataGridView dgvPizza;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnLarge;
        private System.Windows.Forms.Button btnXLarge;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.Label lblLastOrderTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkAnchovy;
        private System.Windows.Forms.CheckBox chkBellPepper;
        private System.Windows.Forms.CheckBox chkBlackOlive;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkHotPepper;
        private System.Windows.Forms.CheckBox chkGreenOlive;
        private System.Windows.Forms.CheckBox chkPaneer;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.ListBox lstPizzaSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TabControl tctlOrders;
    }
}

