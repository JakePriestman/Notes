using NoteTakingApp.Resources;
using System;
using System.IO;
using System.Windows.Forms;

namespace NoteTakingApp
{
	public partial class Notes : Form
	{
		private OpenFileDialog _openFileDialog;
		private SaveFileDialog _saveFileDialog;
		private FontDialog _fontDialog;


		public Notes()
		{
			InitializeComponent();
			_fontDialog = new FontDialog();
			
		}
		
		private void NewFile()
		{
			try
			{
				if(!string.IsNullOrEmpty(this.textBox.Text)) 
				{
					DialogResult dialogResult = MessageBox.Show("Do you want to save?", "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(dialogResult == DialogResult.Yes)
					{
						_saveFileDialog = new SaveFileDialog();
						if (_saveFileDialog.ShowDialog() == DialogResult.OK)
						{
							File.WriteAllText(_saveFileDialog.FileName, this.textBox.Text);
						}
					}
				}
				else
				{
					this.textBox.Text = string.Empty;
					this.Text = "Untitled";
				}
			}
			catch(Exception ex)
			{
				throw;
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewFile();
		}

		private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Notes form = new Notes();
			form.Show();
		}

		private void OpenFile()
		{
			try
			{
				_openFileDialog = new OpenFileDialog();

				if(_openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.textBox.Text = File.ReadAllText(_openFileDialog.FileName);
				}
			}
			catch(Exception ex)
			{
				throw;
			}
		}
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFile();
		}
		private void SaveFile()
		{
			try
			{
				if(!string.IsNullOrEmpty(this.textBox.Text))
				{
					_saveFileDialog = new SaveFileDialog();
					_saveFileDialog.Filter = "Text File (*.txt) | *.txt";
					if (_saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						File.WriteAllText(_saveFileDialog.FileName, this.textBox.Text);
					}
				}
				else
				{
					MessageBox.Show("The file is empty!");
				}
			}
			catch(Exception ex)
			{
				throw;
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFile();
		}

		private void SaveFileAs()
		{
			try
			{
				if (!string.IsNullOrEmpty(this.textBox.Text))
				{
					_saveFileDialog = new SaveFileDialog();
					_saveFileDialog.Filter = "Text File (*.txt) | *.txt | All Files (*.*) | *.*";

					if (_saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						File.WriteAllText(_saveFileDialog.FileName, this.textBox.Text);
					}
				}
				else
				{
					MessageBox.Show("The file is empty!");
				}
			}
			catch (Exception ex)
			{
				throw;
			}
			
		}
		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileAs();
		}

		private void Exit()
		{
			if(!string.IsNullOrEmpty(this.textBox.Text))
			{
				DialogResult dialogResult = MessageBox.Show("Do you want to save?", "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						File.WriteAllText(saveFileDialog.FileName, this.textBox.Text);
					}
				}
			}
			else
			{
				Close();
			}
		}
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void fontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{

				if(_fontDialog.ShowDialog() == DialogResult.OK)
				{
					this.textBox.Font = _fontDialog.Font;
				}
			}
			catch(Exception ex)
			{
				throw;
			}
		}

	}
}
