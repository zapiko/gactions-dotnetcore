﻿using System.Collections.Generic;

namespace ActionsSDK
{
    public class ExpectedInput
    {
        public InputPrompt inputPrompt { get; set; }
        public IList<ExpectedIntent> possibleIntents { get; set; }
        public IList<string> speechBiasingHints { get; set; }

        public ExpectedInput(InputPrompt InputPrompt, ExpectedIntent PossibleIntent)
        {
            inputPrompt = InputPrompt;
            possibleIntents = new List<ExpectedIntent>();
            possibleIntents.Add(PossibleIntent);
        }

    }


}