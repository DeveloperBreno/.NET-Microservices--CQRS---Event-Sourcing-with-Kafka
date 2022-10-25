using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class EditMessageCommand : Basecommand
    {
        public string Message { get; set; }
    }
}