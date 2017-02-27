﻿using NullDesk.Extensions.Mailer.Core.Fluent.Extensions;

namespace NullDesk.Extensions.Mailer.Core.Fluent
{

    public partial class MessageBuilder //root
    {
        public class BuildSubjectStep : BuilderContext
        {
            public BuildSubjectStep(MailerMessage context) : base(context) { }

            public BuildWithSubjectStep Subject(string subject)
                => new BuildWithSubjectStep(Context.WithSubject(subject));

            public BuildWithSubjectStep WithOutSubject()
                => new BuildWithSubjectStep(Context);

            public class BuildWithSubjectStep : BuilderContext
            {
                public BuildWithSubjectStep(MailerMessage context) : base(context) { }

                public BuildRecipientsStep And
                    => new BuildRecipientsStep(Context);
            }
        }
    }
}