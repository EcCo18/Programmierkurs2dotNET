namespace Programmierkurs2
{
    public class CdStart : Command
    {
        private readonly CdPlayer player;
        
        public CdStart(CdPlayer player)
        {
            this.player = player;
        }

        public override void execute()
        {
            player.Start();
        }
    }
}