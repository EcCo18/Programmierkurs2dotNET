namespace Programmierkurs2
{
    public class GaragentorRunter : Command
    {
        private readonly Garagentor garagentor;

        public GaragentorRunter(Garagentor garagentor)
        {
            this.garagentor = garagentor;
        }
        
        public override void execute()
        {
            this.garagentor.Runter();    
        }
    }
}