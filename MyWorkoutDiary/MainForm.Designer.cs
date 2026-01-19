namespace MyWorkoutDiary
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewWorkouts = new System.Windows.Forms.DataGridView();
            this.groupBoxNew = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numReps = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numSets = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbExercise = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.rbDateDesc = new System.Windows.Forms.RadioButton();
            this.rbDateAsc = new System.Windows.Forms.RadioButton();
            this.rbWeightDesc = new System.Windows.Forms.RadioButton();
            this.rbWeightAsc = new System.Windows.Forms.RadioButton();
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFilterExercise = new System.Windows.Forms.Button();
            this.cmbFilterExercise = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkouts)).BeginInit();
            this.groupBoxNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSets)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewWorkouts
            // 
            this.dataGridViewWorkouts.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewWorkouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkouts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewWorkouts.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewWorkouts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWorkouts.Name = "dataGridViewWorkouts";
            this.dataGridViewWorkouts.RowHeadersWidth = 51;
            this.dataGridViewWorkouts.RowTemplate.Height = 24;
            this.dataGridViewWorkouts.Size = new System.Drawing.Size(873, 250);
            this.dataGridViewWorkouts.TabIndex = 0;
            // 
            // groupBoxNew
            // 
            this.groupBoxNew.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBoxNew.Controls.Add(this.btnClear);
            this.groupBoxNew.Controls.Add(this.btnDelete);
            this.groupBoxNew.Controls.Add(this.btnUpdate);
            this.groupBoxNew.Controls.Add(this.btnAdd);
            this.groupBoxNew.Controls.Add(this.txtNotes);
            this.groupBoxNew.Controls.Add(this.label6);
            this.groupBoxNew.Controls.Add(this.numWeight);
            this.groupBoxNew.Controls.Add(this.label5);
            this.groupBoxNew.Controls.Add(this.numReps);
            this.groupBoxNew.Controls.Add(this.label4);
            this.groupBoxNew.Controls.Add(this.numSets);
            this.groupBoxNew.Controls.Add(this.label3);
            this.groupBoxNew.Controls.Add(this.cmbExercise);
            this.groupBoxNew.Controls.Add(this.label2);
            this.groupBoxNew.Controls.Add(this.datePicker);
            this.groupBoxNew.Controls.Add(this.label1);
            this.groupBoxNew.Location = new System.Drawing.Point(12, 256);
            this.groupBoxNew.Name = "groupBoxNew";
            this.groupBoxNew.Size = new System.Drawing.Size(371, 482);
            this.groupBoxNew.TabIndex = 1;
            this.groupBoxNew.TabStop = false;
            this.groupBoxNew.Text = "Новая тренировка";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(278, 422);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(278, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(143, 422);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(143, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(7, 394);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(121, 50);
            this.txtNotes.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Заметки";
            // 
            // numWeight
            // 
            this.numWeight.Location = new System.Drawing.Point(9, 309);
            this.numWeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(120, 22);
            this.numWeight.TabIndex = 9;
            this.numWeight.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вес (кг)";
            // 
            // numReps
            // 
            this.numReps.Location = new System.Drawing.Point(9, 231);
            this.numReps.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numReps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numReps.Name = "numReps";
            this.numReps.Size = new System.Drawing.Size(120, 22);
            this.numReps.TabIndex = 7;
            this.numReps.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Повторения";
            // 
            // numSets
            // 
            this.numSets.Location = new System.Drawing.Point(9, 156);
            this.numSets.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSets.Name = "numSets";
            this.numSets.Size = new System.Drawing.Size(120, 22);
            this.numSets.TabIndex = 5;
            this.numSets.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Подходы";
            // 
            // cmbExercise
            // 
            this.cmbExercise.FormattingEnabled = true;
            this.cmbExercise.Items.AddRange(new object[] {
            "- Жим лежа",
            "- Приседания",
            "- Становая тяга",
            "- Подтягивания",
            "- Отжимания",
            "- Бицепс",
            "- Трицепс"});
            this.cmbExercise.Location = new System.Drawing.Point(7, 94);
            this.cmbExercise.Name = "cmbExercise";
            this.cmbExercise.Size = new System.Drawing.Size(121, 24);
            this.cmbExercise.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Упражнение";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(9, 38);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBoxSearch.Controls.Add(this.groupBox1);
            this.groupBoxSearch.Controls.Add(this.btnFilterDate);
            this.groupBoxSearch.Controls.Add(this.dateTo);
            this.groupBoxSearch.Controls.Add(this.label10);
            this.groupBoxSearch.Controls.Add(this.dateFrom);
            this.groupBoxSearch.Controls.Add(this.label9);
            this.groupBoxSearch.Controls.Add(this.btnFilterExercise);
            this.groupBoxSearch.Controls.Add(this.cmbFilterExercise);
            this.groupBoxSearch.Controls.Add(this.label8);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Controls.Add(this.label7);
            this.groupBoxSearch.Location = new System.Drawing.Point(471, 256);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(415, 482);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск и фильтрация ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.rbDateDesc);
            this.groupBox1.Controls.Add(this.rbDateAsc);
            this.groupBox1.Controls.Add(this.rbWeightDesc);
            this.groupBox1.Controls.Add(this.rbWeightAsc);
            this.groupBox1.Location = new System.Drawing.Point(10, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 131);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(132, 57);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(114, 27);
            this.btnShowAll.TabIndex = 13;
            this.btnShowAll.Text = "Показать все";
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(132, 21);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(114, 29);
            this.btnSort.TabIndex = 12;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // rbDateDesc
            // 
            this.rbDateDesc.AutoSize = true;
            this.rbDateDesc.Location = new System.Drawing.Point(7, 99);
            this.rbDateDesc.Name = "rbDateDesc";
            this.rbDateDesc.Size = new System.Drawing.Size(90, 20);
            this.rbDateDesc.TabIndex = 3;
            this.rbDateDesc.TabStop = true;
            this.rbDateDesc.Text = "По дате ↓";
            this.rbDateDesc.UseVisualStyleBackColor = true;
            // 
            // rbDateAsc
            // 
            this.rbDateAsc.AutoSize = true;
            this.rbDateAsc.Location = new System.Drawing.Point(7, 73);
            this.rbDateAsc.Name = "rbDateAsc";
            this.rbDateAsc.Size = new System.Drawing.Size(90, 20);
            this.rbDateAsc.TabIndex = 2;
            this.rbDateAsc.TabStop = true;
            this.rbDateAsc.Text = "По дате ↑";
            this.rbDateAsc.UseVisualStyleBackColor = true;
            // 
            // rbWeightDesc
            // 
            this.rbWeightDesc.AutoSize = true;
            this.rbWeightDesc.Location = new System.Drawing.Point(7, 46);
            this.rbWeightDesc.Name = "rbWeightDesc";
            this.rbWeightDesc.Size = new System.Drawing.Size(90, 20);
            this.rbWeightDesc.TabIndex = 1;
            this.rbWeightDesc.TabStop = true;
            this.rbWeightDesc.Text = "По весу ↓";
            this.rbWeightDesc.UseVisualStyleBackColor = true;
            // 
            // rbWeightAsc
            // 
            this.rbWeightAsc.AutoSize = true;
            this.rbWeightAsc.Location = new System.Drawing.Point(7, 19);
            this.rbWeightAsc.Name = "rbWeightAsc";
            this.rbWeightAsc.Size = new System.Drawing.Size(90, 20);
            this.rbWeightAsc.TabIndex = 0;
            this.rbWeightAsc.TabStop = true;
            this.rbWeightAsc.Text = "По весу ↑";
            this.rbWeightAsc.UseVisualStyleBackColor = true;
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.Location = new System.Drawing.Point(13, 308);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(75, 23);
            this.btnFilterDate.TabIndex = 10;
            this.btnFilterDate.Text = "По дате";
            this.btnFilterDate.UseVisualStyleBackColor = true;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(13, 269);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 22);
            this.dateTo.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "по";
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(13, 220);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 22);
            this.dateFrom.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Дата с";
            // 
            // btnFilterExercise
            // 
            this.btnFilterExercise.Location = new System.Drawing.Point(7, 169);
            this.btnFilterExercise.Name = "btnFilterExercise";
            this.btnFilterExercise.Size = new System.Drawing.Size(75, 23);
            this.btnFilterExercise.TabIndex = 5;
            this.btnFilterExercise.Text = "Фильтр";
            this.btnFilterExercise.UseVisualStyleBackColor = true;
            // 
            // cmbFilterExercise
            // 
            this.cmbFilterExercise.FormattingEnabled = true;
            this.cmbFilterExercise.Items.AddRange(new object[] {
            "- Жим лежа",
            "- Приседания",
            "- Становая тяга",
            "- Подтягивания",
            "- Отжимания",
            "- Бицепс",
            "- Трицепс"});
            this.cmbFilterExercise.Location = new System.Drawing.Point(7, 138);
            this.cmbFilterExercise.Name = "cmbFilterExercise";
            this.cmbFilterExercise.Size = new System.Drawing.Size(121, 24);
            this.cmbFilterExercise.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Упражнение";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(10, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Поиск";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 764);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxNew);
            this.Controls.Add(this.dataGridViewWorkouts);
            this.Name = "MainForm";
            this.Text = "WorkoutDiary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkouts)).EndInit();
            this.groupBoxNew.ResumeLayout(false);
            this.groupBoxNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSets)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWorkouts;
        private System.Windows.Forms.GroupBox groupBoxNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.NumericUpDown numReps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbExercise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFilterExercise;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFilterExercise;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDateDesc;
        private System.Windows.Forms.RadioButton rbDateAsc;
        private System.Windows.Forms.RadioButton rbWeightDesc;
        private System.Windows.Forms.RadioButton rbWeightAsc;
        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSort;
    }
}

