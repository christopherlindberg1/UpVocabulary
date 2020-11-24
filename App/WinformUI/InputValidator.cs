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




        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        /// <summary>
        ///   Internal method used to keep track of whether messages has been presented.
        /// </summary>
        private bool HasSentMessage
        {
            get { return this._hasSentMessage; }
            set { this._hasSentMessage = value; }
        }


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
        internal string GetMessages()
        {
            StringBuilder messageBuilder = new StringBuilder();

            foreach (string message in this.Messages)
            {
                messageBuilder.Append(message + "\n");
            }

            this.HasSentMessage = true;
            return messageBuilder.ToString();
        }

        internal bool ValidateTextBoxString(TextBox element, string errorMessageForNullOrEmpty)
        {
            if (String.IsNullOrWhiteSpace(element.Text))
            {
                AddMessage(errorMessageForNullOrEmpty);
                return false;
            }

            return true;
        }

        internal bool ValidateComboBoxItemIsSelected(ComboBox element, string errorMessageIfNotSelected)
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
