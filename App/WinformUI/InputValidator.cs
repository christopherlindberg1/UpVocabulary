using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI
{
    class InputValidator
    {
        private readonly List<string> _messages = new List<string>();
        private bool _hasSentMessage = false;




        /**
         * 
         * ===================  Properties  ===================
         * 
         */
        private List<string> Messages
        {
            get { return this._messages; }
        }

        private bool HasSentMessage
        {
            get { return this._hasSentMessage; }
            set { this._hasSentMessage = value; }
        }



        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        /// <summary>
        ///   Adds message to a List with messages.
        /// </summary>
        /// <param name="message"></param>
        public void AddMessage(string message)
        {
            if (this.HasSentMessage)
            {
                this.Messages.Clear();
                this.HasSentMessage = false;
            }

            this.Messages.Add(message);
        }

        /// <summary>
        ///   Returns a string representation of all messages.
        /// </summary>
        /// <returns>String with message.</returns>
        public string GetMessages()
        {
            StringBuilder messageBuilder = new StringBuilder();

            foreach (string message in this.Messages)
            {
                messageBuilder.Append(message + "\n");
            }

            this.HasSentMessage = true;
            return messageBuilder.ToString();
        }

        public bool ValidateTextBoxString(TextBox element, string errorMessageForNullOrEmpty)
        {
            if (String.IsNullOrWhiteSpace(element.Text))
            {
                AddMessage(errorMessageForNullOrEmpty);
                return false;
            }

            return true;
        }

        public bool ValidateComboBoxItemIsSelected(ComboBox element, string errorMessageIfNotSelected)
        {
            if (element.SelectedIndex == -1)
            {
                AddMessage(errorMessageIfNotSelected);
                return false;
            }

            return true;
        }

    }
}
