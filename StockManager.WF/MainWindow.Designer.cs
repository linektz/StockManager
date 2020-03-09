namespace StockManager.WF
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGestCategories = new System.Windows.Forms.Button();
            this.buttonGestSortiesStocks = new System.Windows.Forms.Button();
            this.buttonGestEntreesStocks = new System.Windows.Forms.Button();
            this.buttonGestProduits = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGestCategories
            // 
            this.buttonGestCategories.BackColor = System.Drawing.Color.Black;
            this.buttonGestCategories.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonGestCategories.Location = new System.Drawing.Point(579, 134);
            this.buttonGestCategories.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGestCategories.Name = "buttonGestCategories";
            this.buttonGestCategories.Size = new System.Drawing.Size(200, 65);
            this.buttonGestCategories.TabIndex = 0;
            this.buttonGestCategories.Text = "Gestion Catégories";
            this.buttonGestCategories.UseVisualStyleBackColor = false;
            
            // 
            // buttonGestSortiesStocks
            // 
            this.buttonGestSortiesStocks.BackColor = System.Drawing.Color.Black;
            this.buttonGestSortiesStocks.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonGestSortiesStocks.Location = new System.Drawing.Point(579, 300);
            this.buttonGestSortiesStocks.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGestSortiesStocks.Name = "buttonGestSortiesStocks";
            this.buttonGestSortiesStocks.Size = new System.Drawing.Size(200, 65);
            this.buttonGestSortiesStocks.TabIndex = 1;
            this.buttonGestSortiesStocks.Text = "Gestion sorties stock";
            this.buttonGestSortiesStocks.UseVisualStyleBackColor = false;
            this.buttonGestSortiesStocks.Click += new System.EventHandler(this.buttonGestSortiesStocks_Click);
            // 
            // buttonGestEntreesStocks
            // 
            this.buttonGestEntreesStocks.BackColor = System.Drawing.Color.Black;
            this.buttonGestEntreesStocks.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonGestEntreesStocks.Location = new System.Drawing.Point(219, 300);
            this.buttonGestEntreesStocks.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGestEntreesStocks.Name = "buttonGestEntreesStocks";
            this.buttonGestEntreesStocks.Size = new System.Drawing.Size(200, 65);
            this.buttonGestEntreesStocks.TabIndex = 2;
            this.buttonGestEntreesStocks.Text = "Gestion entrées stocks";
            this.buttonGestEntreesStocks.UseVisualStyleBackColor = false;
            this.buttonGestEntreesStocks.Click += new System.EventHandler(this.buttonGestEntreesStocks_Click);
            // 
            // buttonGestProduits
            // 
            this.buttonGestProduits.BackColor = System.Drawing.Color.Black;
            this.buttonGestProduits.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonGestProduits.Location = new System.Drawing.Point(219, 134);
            this.buttonGestProduits.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGestProduits.Name = "buttonGestProduits";
            this.buttonGestProduits.Size = new System.Drawing.Size(200, 65);
            this.buttonGestProduits.TabIndex = 3;
            this.buttonGestProduits.Text = "Gestion Produits";
            this.buttonGestProduits.UseVisualStyleBackColor = false;
            
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGestProduits);
            this.Controls.Add(this.buttonGestEntreesStocks);
            this.Controls.Add(this.buttonGestSortiesStocks);
            this.Controls.Add(this.buttonGestCategories);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGestCategories;
        private System.Windows.Forms.Button buttonGestSortiesStocks;
        private System.Windows.Forms.Button buttonGestEntreesStocks;
        private System.Windows.Forms.Button buttonGestProduits;
        private System.Windows.Forms.Label label1;
    }
}

