namespace Tapetrullar
{
    using System;

    class Program
    {
        static void Main()
        {
            double ceilingHeight = 2.5;
            double wallPaperLenght = 10;
            double wallPaperWidth = 0.53;
            double wallPaperRepeat = 0.265;
            //avrunda upp för att vi behöver hela rapporter
            double repeatsNeeded = Math.Ceiling(ceilingHeight / wallPaperRepeat);
            double sheetLength = repeatsNeeded * wallPaperRepeat;

            //avrunda ner för att vi kan inte använda den sista biten som en hel våd
            double sheetsPerRoll = Math.Floor(wallPaperLenght / sheetLength);
            
            double roomLongWall = 4;
            double roomShortWall = 3.5;
            double roomWindow = 1.5;
            double roomDoor = 0.7;
            double roomWallWidth = roomLongWall * 2 + roomShortWall * 2 - roomDoor - roomWindow;

            //avrunda upp för vi behöver hela våder
            double wallPaperWidthsNeeded = Math.Ceiling(roomWallWidth / wallPaperWidth);

            //avrunda upp för vi kan bara köpa hela rullar
            double wallPaperRollsNeeded = Math.Ceiling(wallPaperWidthsNeeded / sheetsPerRoll);

            Console.WriteLine("Du behöver köpa " + wallPaperRollsNeeded + " rullar tapet.");

        }
    }
}
