using System;

namespace FirstProject
{
	public class Room
	{
		int height;
		int width;
		char[,] roomArr;

		private const char yWall = '|';
		private const char xWall = '-';
		private const char fill = 'o';

		public Room(int? w = null, int? h = null)
		{
			this.width = w ?? GetRandomRoomDimension() + 2;
			this.height = h ?? GetRandomRoomDimension() + 2;

			roomArr = new char[this.height, this.width];

			for(int x = 0; x < this.height; x++)
            {
				for(int y = 0; y < this.width; y++)
                {
					if (x == 0 || x == this.height - 1) roomArr[x,y] = xWall;
					else if ((y == 0 || y == this.width - 1) && (x != 0 || x != this.height - 1)) roomArr[x,y] = yWall;
					else roomArr[x,y] = fill;
                }
            }
		}

		public void ShowRoom()
        {
			for(int x = 0; x < this.height; x++)
            {
				for(int y = 0; y < this.width; y++)
                {
					Console.Write(roomArr[x,y]);
					if (x != height - 1 && y == this.width - 1) Console.Write("\n");
                }
            }
			
        }


		public static int GetRandomRoomDimension()
        {
			var rand = new Random();
			int randomDimension = rand.Next(1, 32);
				
			return randomDimension;

		}
	}
}
