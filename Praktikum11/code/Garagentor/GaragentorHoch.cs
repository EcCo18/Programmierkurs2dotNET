namespace Programmierkurs2
{
    public class GaragentorHoch : Command
    {
        private readonly Garagentor garagentor;

        public GaragentorHoch(Garagentor garagentor)
        {
            this.garagentor = garagentor;
        }

        public override void execute()
        {
            garagentor.Hoch();
        }
    }
}