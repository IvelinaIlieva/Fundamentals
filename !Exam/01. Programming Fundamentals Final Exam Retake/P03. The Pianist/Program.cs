using System;
using System.Collections.Generic;

namespace P03._The_Pianist
{
    public class Piece
    {
        public Piece(string name, string composer, string key)
        {
            this.Name = name;
            this.Composer = composer;
            this.Key = key;
        }
        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            int countOfPieces = int.Parse(Console.ReadLine());

            List<Piece> pieces = new List<Piece>();

            for (int i = 1; i <= countOfPieces; i++)
            {
                string[] pieceInfo = Console.ReadLine().Split('|');

                string name = pieceInfo[0];
                string composer = pieceInfo[1];
                string key = pieceInfo[2];

                Piece piece = new Piece(name, composer, key);

                pieces.Add(piece);
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = command.Split('|');

                string cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    string name = cmdArgs[1];
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];

                    if (pieces.FindAll(p => p.Name == name).Count != 0)
                    {
                        Console.WriteLine($"{name} is already in the collection!");
                        continue;
                    }

                    Piece piece = new Piece(name, composer, key);
                    pieces.Add(piece);

                    Console.WriteLine($"{name} by {composer} in {key} added to the collection!");
                }
                else if (cmdType == "Remove")
                {
                    string name = cmdArgs[1];

                    if (pieces.FindAll(p => p.Name == name).Count == 0)
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }
                    else
                    {
                        pieces.RemoveAll(p => p.Name == name);
                        Console.WriteLine($"Successfully removed {name}!");
                    }
                }
                else if (cmdType == "ChangeKey")
                {
                    string name = cmdArgs[1];
                    string key = cmdArgs[2];

                    if (pieces.FindAll(p => p.Name == name).Count == 0)
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }
                    else
                    {
                        Piece currPiece = pieces.Find(p => p.Name == name);
                        currPiece.Key = key;
                        Console.WriteLine($"Changed the key of {name} to {key}!");
                    }
                }
            }

            foreach (Piece piece in pieces)
            {
                Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }
        }
    }
}
