using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;



namespace AppFeatures
{
    [Serializable()]
    public class AppSettings : ISerializable
    {
        private AppLanguages _appLanguage;
        private bool _autoPromptQuestionAfterCorrectAnswer;
        private bool _autoPromptQuestionAfterIncorrectAnswer;
        private int _delayBeforePromptingNextQuestionAfterCorrectAnswer;
        private int _delayBeforePromptingNextQuestionAfterIncorrectAnswer;





        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        /// <summary>
        ///   Language for all text in the application, except the words used for
        ///   the practice itself.
        /// </summary>
        public AppLanguages AppLanguage
        {
            get => _appLanguage;

            set => _appLanguage = value;
        }

        /// <summary>
        ///   Determines whether the next question should be prompted automaticlly
        ///   after the user has given a correct translation.
        /// </summary>
        public bool AutoPromptQuestionAfterCorrectAnswer
        {
            get => _autoPromptQuestionAfterCorrectAnswer;

            set => _autoPromptQuestionAfterCorrectAnswer = value;
        }

        /// <summary>
        ///   Determines whether the next question should be prompted automaticlly
        ///   after the user has given an icorrect translation.
        /// </summary>
        public bool AutoPromptQuestionAfterIncorrectAnswer
        {
            get => _autoPromptQuestionAfterIncorrectAnswer;

            set => _autoPromptQuestionAfterIncorrectAnswer = value;
        }

        /// <summary>
        ///   Delay in milliseconds for prompting the next question
        ///   to the user after a correct translation.
        /// </summary>
        public int DelayBeforePromptingNextQuestionAfterCorrectAnswer
        {
            get => _delayBeforePromptingNextQuestionAfterCorrectAnswer;

            set
            {
                if (value < 0 || value > 30000)
                {
                    throw new ArgumentOutOfRangeException(
                        "DelayBeforePromptingNextQuestion",
                        "DelayBeforePromptingNextQuestion must be in the range 0 - 30000.");
                }

                _delayBeforePromptingNextQuestionAfterCorrectAnswer = value;
            }
        }

        /// <summary>
        ///   Delay in milliseconds for prompting the next question
        ///   to the user after an incorrect translation.
        /// </summary>
        public int DelayBeforePromptingNextQuestionAfterIncorrectAnswer
        {
            get => _delayBeforePromptingNextQuestionAfterIncorrectAnswer;

            set
            {
                if (value < 0 || value > 30000)
                {
                    throw new ArgumentOutOfRangeException(
                        "DelayBeforePromptingNextQuestion",
                        "DelayBeforePromptingNextQuestion must be in the range 0 - 30000.");
                }

                _delayBeforePromptingNextQuestionAfterIncorrectAnswer = value;
            }
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("AppLanguage", AppLanguage);
            info.AddValue("AutoPromptQuestionAfterCorrectAnswer", AutoPromptQuestionAfterCorrectAnswer);
            info.AddValue("AutoPromptQuestionAfterIncorrectAnswer", AutoPromptQuestionAfterIncorrectAnswer);
            info.AddValue("DelayBeforePromptingNextQuestionAfterCorrectAnswer", DelayBeforePromptingNextQuestionAfterCorrectAnswer);
            info.AddValue("DelayBeforePromptingNextQuestionAfterIncorrectAnswer", DelayBeforePromptingNextQuestionAfterIncorrectAnswer);
        }

        public AppSettings(SerializationInfo info, StreamingContext context)
        {
            AppLanguage = (AppLanguages)info.GetValue("AppLanguage", typeof(AppLanguages));
            AutoPromptQuestionAfterCorrectAnswer = (bool)info.GetValue("AutoPromptQuestionAfterCorrectAnswer", typeof(bool));
            AutoPromptQuestionAfterIncorrectAnswer = (bool)info.GetValue("AutoPromptQuestionAfterIncorrectAnswer", typeof(bool));
            DelayBeforePromptingNextQuestionAfterCorrectAnswer = (int)info.GetValue("DelayBeforePromptingNextQuestionAfterCorrectAnswer", typeof(int));
            DelayBeforePromptingNextQuestionAfterIncorrectAnswer = (int)info.GetValue("DelayBeforePromptingNextQuestionAfterIncorrectAnswer", typeof(int));
        }
    }
}
