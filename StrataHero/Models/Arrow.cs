//namespace StrataHero.Models
//{
//    public class Arrow
//    {
//        public string ArrowSVG { get; set; }

//        private readonly Direction direction;
//        private readonly State state;


//        public Arrow(Direction direction, State state)
//        {
//            this.direction = direction;
//            this.state = state;
//        }

//        private void SetArrowSVG()
//        {
//            if(this.direction == Direction.Up)
//            {
//                ArrowSVG = "<svg class=\"up\" style=\"transform: rotate(270deg); color: @upColor;\" xmlns=\"http://www.w3.org/2000/svg\" width=\"19.99\" height=\"18\"><path fill=\"currentColor\" d=\"M10.029 5H0v7.967h10.029V18l9.961-9.048L10.029 0v5z\" /></svg>";
//            }
//            else if(this.direction == Direction.Down)
//            {
//                ArrowSVG = "<svg class=\"down\" style=\"transform: rotate(90deg); color: @downColor;\" xmlns=\"http://www.w3.org/2000/svg\" width=\"19.99\" height=\"18\"><path fill=\"currentColor\" d=\"M10.029 5H0v7.967h10.029V18l9.961-9.048L10.029 0v5z\" /></svg>";
//            }
//            else if (this.direction == Direction.Left)
//            {
//                ArrowSVG = "<svg class=\"left\" style=\"transform: rotate(180deg); color: @leftColor;\" xmlns=\"http://www.w3.org/2000/svg\" width=\"19.99\" height=\"18\"><path fill=\"currentColor\" d=\"M10.029 5H0v7.967h10.029V18l9.961-9.048L10.029 0v5z\" /></svg>";
//            }
//            else
//            {
//                ArrowSVG = "<svg class=\"right\" style=\"color: @rightColor;\" xmlns=\"http://www.w3.org/2000/svg\" width=\"19.99\" height=\"18\"><path fill=\"currentColor\" d=\"M10.029 5H0v7.967h10.029V18l9.961-9.048L10.029 0v5z\" /></svg>";
//            }
//        }
//    }
//    public enum Direction { Left, Right, Up, Down };
//    public enum State { Pressed, ToPress, Upcoming };
//}
