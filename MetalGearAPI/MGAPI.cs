namespace MetalGearAPI
{
    public class MGAPI
    {
        public MGAPI(Game game = Game.MGS4)
        {
            SetGame.Game = game;
            MakeInstance(game);
        }
        private class SetGame
        {
            public static Game Game;
        }
        private class Common
        {
            public static MGS4 MGS4;
        }
        public bool DemiGod
        {
            get => this.DemiGod;
            set
            {
                switch (SetGame.Game)
                {
                    case Game.MGS4: MGS4.DemiGod(); break;
                }
            }
        }
        public void UnlockAll()
        {
            switch (SetGame.Game)
            {
                case Game.MGS4: MGS4.UnlockAll(); break;
            }
        }
        private void MakeInstance(Game game)
        {
            switch (game)
            {
                case Game.MGS4:
                    if (Common.MGS4 == null)
                    {
                        Common.MGS4 = new MGS4();
                    }
                    break;
                case Game.MGS3:
                case Game.MGS5:
                    break;
            }
        }

        public void ChangeGame(Game game)
        {
            SetGame.Game = game;
            MakeInstance(CurrentGame);
        }
        public Game CurrentGame => SetGame.Game; 
        public MGS4 MGS4 => new MGS4();

    }
}
