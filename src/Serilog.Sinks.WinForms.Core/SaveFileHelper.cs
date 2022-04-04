namespace Serilog.Sinks.WinForms.Core
{
    public static class SaveFileHelper
    {
        internal static void SaveLogsToFile(string fileContent)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog { Filter = @"Text Files | *.txt| Log Files |*.log" };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.AppendAllText(saveFileDialog.FileName, fileContent);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error Saving Log File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
