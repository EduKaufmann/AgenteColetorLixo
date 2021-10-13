using System;
using System.Collections.Generic;
using System.Linq;

namespace AgenteColetorLixo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Crete Matriz and fixed points
            String[,] array2D = new String[14, 15];
            Initialize2DArray(array2D);
            Print2DArray(array2D);
            Console.WriteLine("Matriz Criada");
            Console.WriteLine();

            CreateBuilding(array2D, 2, 2);
            CreateBuilding(array2D, 2, 10);
            CreateBuilding(array2D, 5, 6);
            CreateBuilding(array2D, 8, 2);
            CreateBuilding(array2D, 8, 10);
            Print2DArray(array2D);
            Console.WriteLine("Prédios Criados");
            Console.WriteLine();

            array2D[2, 1] = "VE";
            array2D[3, 1] = "VE";
            array2D[2, 13] = "VE";
            array2D[3, 13] = "VE";
            array2D[8, 1] = "VE";
            array2D[9, 1] = "VE";
            array2D[8, 7] = "VE";
            array2D[8, 8] = "VE";
            array2D[8, 13] = "VE";
            array2D[9, 13] = "VE";
            Print2DArray(array2D);
            Console.WriteLine("Veiculos Criados");
            Console.WriteLine();
            #endregion

            #region Create Garbages and yours objects
            List<Garbage> garbages = new List<Garbage>();

            array2D[1, 2] = "LO";
            Garbage LO1 = new Garbage("LO", Tuple.Create(1, 2));
            garbages.Add(LO1);
            array2D[1, 3] = "LS";
            Garbage LS1 = new Garbage("LS", Tuple.Create(1, 3));
            garbages.Add(LS1);
            array2D[1, 4] = "LE";
            Garbage LE1 = new Garbage("LE", Tuple.Create(1, 4));
            garbages.Add(LE1);

            array2D[1, 10] = "LO";
            Garbage LO2 = new Garbage("LO", Tuple.Create(1, 10));
            garbages.Add(LO2);
            array2D[1, 11] = "LS";
            Garbage LS2 = new Garbage("LS", Tuple.Create(1, 11));
            garbages.Add(LS2);
            array2D[1, 12] = "LE";
            Garbage LE2 = new Garbage("LE", Tuple.Create(1, 12));
            garbages.Add(LE2);

            array2D[4, 6] = "LO";
            Garbage LO3 = new Garbage("LO", Tuple.Create(4, 6));
            garbages.Add(LO3);
            array2D[4, 7] = "LS";
            Garbage LS3 = new Garbage("LS", Tuple.Create(4, 7));
            garbages.Add(LS3);
            array2D[4, 8] = "LE";
            Garbage LE3 = new Garbage("LE", Tuple.Create(4, 8));
            garbages.Add(LE3);

            array2D[7, 2] = "LO";
            Garbage LO4 = new Garbage("LO", Tuple.Create(7, 2));
            garbages.Add(LO4);
            array2D[7, 3] = "LS";
            Garbage LS4 = new Garbage("LS", Tuple.Create(7, 3));
            garbages.Add(LS4);
            array2D[7, 4] = "LE";
            Garbage LE4 = new Garbage("LE", Tuple.Create(7, 4));
            garbages.Add(LE4);

            array2D[7, 10] = "LO";
            Garbage LO5 = new Garbage("LO", Tuple.Create(7, 10));
            garbages.Add(LO5);
            array2D[7, 11] = "LS";
            Garbage LS5 = new Garbage("LS", Tuple.Create(7, 11));
            garbages.Add(LS5);
            array2D[7, 12] = "LE";
            Garbage LE5 = new Garbage("LE", Tuple.Create(7, 12));
            garbages.Add(LE5);
            Print2DArray(array2D);
            Console.WriteLine("Lixeiras Criadas");
            Console.WriteLine();
            #endregion

            #region Create Containers
            array2D[13, 0] = "CE";
            array2D[13, 1] = "CS";
            array2D[13, 2] = "CO";
            array2D[13, 12] = "CE";
            array2D[13, 13] = "CS";
            array2D[13, 14] = "CO";
            Print2DArray(array2D);
            Console.WriteLine("Agentes Containeres Criados");
            Console.WriteLine();
            #endregion

            #region Create random points
            Tuple<int, int> randomPoint;
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = "PE";
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = "PE";
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = "PE";
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = "PE";
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = "PE";
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = "PE";
            Print2DArray(array2D);
            Console.WriteLine("Pessoas Criadas");
            Console.WriteLine();
            #endregion

            #region Create Agents and yours objects
            String typeAgent = "AO";
            String typeGarbage = "LO";
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = typeAgent;
            Agent O1 = new Agent(typeAgent, randomPoint, typeGarbage);
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = typeAgent;
            Agent O2 = new Agent(typeAgent, randomPoint, typeGarbage);
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = typeAgent;
            Agent O3 = new Agent(typeAgent, randomPoint, typeGarbage);

            typeAgent = "AS";
            typeGarbage = "LS";
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = typeAgent;
            Agent S1 = new Agent(typeAgent, randomPoint, typeGarbage);
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = typeAgent;
            Agent S2 = new Agent(typeAgent, randomPoint, typeGarbage);
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = typeAgent;
            Agent S3 = new Agent(typeAgent, randomPoint, typeGarbage);

            typeAgent = "AE";
            typeGarbage = "LE";
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = typeAgent;
            Agent E1 = new Agent(typeAgent, randomPoint, typeGarbage);
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = typeAgent;
            Agent E2 = new Agent(typeAgent, randomPoint, typeGarbage);
            randomPoint = CreateRandomPoint(array2D);
            array2D[randomPoint.Item1, randomPoint.Item2] = typeAgent;
            Agent E3 = new Agent(typeAgent, randomPoint, typeGarbage);
            Print2DArray(array2D);
            Console.WriteLine("Agentes Coletores Criados");
            Console.WriteLine();
            #endregion

            #region Move agents to Garbage and Containers
            #region Organic agent
            Garbage element;
            int result;
            Console.WriteLine("Coluna: " + O1.Local.Item1 + " Linha: " + O1.Local.Item2 + " = " + O1.Type);
            Agent.MoveAgent(array2D, O1);
            Print2DArray(array2D);
            element = garbages.Find(x => x.Local.Item1 == O1.Local.Item1 && x.Local.Item2 == O1.Local.Item2);
            result = Agent.RemoveGarbage(O1, element, array2D);
            while (result == 0)//Agent is not full
            {
                Agent.MoveAgent(array2D, O1);
                Print2DArray(array2D);
                element = garbages.Find(x => x.Local.Item1 == O1.Local.Item1 && x.Local.Item2 == O1.Local.Item2);
                result = Agent.RemoveGarbage(O1, element, array2D);
            }
            if (result == 1)//Agent is full
            {
                //move agent to container
                O1.DestinyAgent = "CO";
                Agent.MoveAgent(array2D, O1);
                Print2DArray(array2D);
                //the agent finished its work and go out
                array2D[O1.Local.Item1, O1.Local.Item2] = "CO";
            }

            Console.WriteLine("Coluna: " + O2.Local.Item1 + " Linha: " + O2.Local.Item2 + " = " + O2.Type);
            Agent.MoveAgent(array2D, O2);
            Print2DArray(array2D);
            element = garbages.Find(x => x.Local.Item1 == O2.Local.Item1 && x.Local.Item2 == O2.Local.Item2);
            result = Agent.RemoveGarbage(O2, element, array2D);
            while (result == 0)//Agent is not full
            {
                Agent.MoveAgent(array2D, O2);
                Print2DArray(array2D);
                element = garbages.Find(x => x.Local.Item1 == O2.Local.Item1 && x.Local.Item2 == O2.Local.Item2);
                result = Agent.RemoveGarbage(O2, element, array2D);
            }
            if (result == 1)//Agent is full
            {
                //move agent to container
                O2.DestinyAgent = "CO";
                Agent.MoveAgent(array2D, O2);
                Print2DArray(array2D);
                //the agent finished its work and go out
                array2D[O2.Local.Item1, O2.Local.Item2] = "CO";
            }

            Console.WriteLine("Coluna: " + O3.Local.Item1 + " Linha: " + O3.Local.Item2 + " = " + O3.Type);
            Agent.MoveAgent(array2D, O3);
            Print2DArray(array2D);
            element = garbages.Find(x => x.Local.Item1 == O3.Local.Item1 && x.Local.Item2 == O3.Local.Item2);
            result = Agent.RemoveGarbage(O3, element, array2D);
            while (result == 0)//Agent is not full
            {
                Agent.MoveAgent(array2D, O3);
                Print2DArray(array2D);
                element = garbages.Find(x => x.Local.Item1 == O3.Local.Item1 && x.Local.Item2 == O3.Local.Item2);
                result = Agent.RemoveGarbage(O3, element, array2D);
            }
            if (result == 1)//Agent is full
            {
                //move agent to container
                O3.DestinyAgent = "CO";
                Agent.MoveAgent(array2D, O3);
                Print2DArray(array2D);
                //the agent finished its work and go out
                array2D[O3.Local.Item1, O3.Local.Item2] = "CO";
            }

            Print2DArray(array2D);
            #endregion

            #region Electronic agent
            Console.WriteLine("Coluna: " + E1.Local.Item1 + " Linha: " + E1.Local.Item2 + " = " + E1.Type);
            Agent.MoveAgent(array2D, E1);
            Print2DArray(array2D);
            element = garbages.Find(x => x.Local.Item1 == E1.Local.Item1 && x.Local.Item2 == E1.Local.Item2);
            result = Agent.RemoveGarbage(E1, element, array2D);
            while (result == 0)//Agent is not full
            {
                Agent.MoveAgent(array2D, E1);
                Print2DArray(array2D);
                element = garbages.Find(x => x.Local.Item1 == E1.Local.Item1 && x.Local.Item2 == E1.Local.Item2);
                result = Agent.RemoveGarbage(E1, element, array2D);
            }
            if (result == 1)//Agent is full
            {
                //move agent to container
                E1.DestinyAgent = "CE";
                Agent.MoveAgent(array2D, E1);
                Print2DArray(array2D);
                //the agent finished its work and go out
                array2D[E1.Local.Item1, E1.Local.Item2] = "CE";
            }

            Console.WriteLine("Coluna: " + E2.Local.Item1 + " Linha: " + E2.Local.Item2 + " = " + E2.Type);
            Agent.MoveAgent(array2D, E2);
            Print2DArray(array2D);
            element = garbages.Find(x => x.Local.Item1 == E2.Local.Item1 && x.Local.Item2 == E2.Local.Item2);
            result = Agent.RemoveGarbage(E2, element, array2D);
            while (result == 0)//Agent is not full
            {
                Agent.MoveAgent(array2D, E2);
                Print2DArray(array2D);
                element = garbages.Find(x => x.Local.Item1 == E2.Local.Item1 && x.Local.Item2 == E2.Local.Item2);
                result = Agent.RemoveGarbage(E2, element, array2D);
            }
            if (result == 1)//Agent is full
            {
                //move agent to container
                E2.DestinyAgent = "CE";
                Agent.MoveAgent(array2D, E2);
                Print2DArray(array2D);
                //the agent finished its work and go out
                array2D[E2.Local.Item1, E2.Local.Item2] = "CE";
            }

            Console.WriteLine("Coluna: " + E3.Local.Item1 + " Linha: " + E3.Local.Item2 + " = " + E3.Type);
            Agent.MoveAgent(array2D, E3);
            Print2DArray(array2D);
            element = garbages.Find(x => x.Local.Item1 == E3.Local.Item1 && x.Local.Item2 == E3.Local.Item2);
            result = Agent.RemoveGarbage(E3, element, array2D);
            while (result == 0)//Agent is not full
            {
                Agent.MoveAgent(array2D, E3);
                Print2DArray(array2D);
                element = garbages.Find(x => x.Local.Item1 == E3.Local.Item1 && x.Local.Item2 == E3.Local.Item2);
                result = Agent.RemoveGarbage(E3, element, array2D);
            }
            if (result == 1)//Agent is full
            {
                //move agent to container
                E3.DestinyAgent = "CE";
                Agent.MoveAgent(array2D, E3);
                Print2DArray(array2D);
                //the agent finished its work and go out
                array2D[E3.Local.Item1, E3.Local.Item2] = "CE";
            }

            Print2DArray(array2D);
            #endregion

            #region #region Dry agent
            Console.WriteLine("Coluna: " + S1.Local.Item1 + " Linha: " + S1.Local.Item2 + " = " + S1.Type);
            Agent.MoveAgent(array2D, S1);
            Print2DArray(array2D);
            element = garbages.Find(x => x.Local.Item1 == S1.Local.Item1 && x.Local.Item2 == S1.Local.Item2);
            result = Agent.RemoveGarbage(S1, element, array2D);
            while (result == 0)//Agent is not full
            {
                Agent.MoveAgent(array2D, S1);
                Print2DArray(array2D);
                element = garbages.Find(x => x.Local.Item1 == S1.Local.Item1 && x.Local.Item2 == S1.Local.Item2);
                result = Agent.RemoveGarbage(S1, element, array2D);
            }
            if (result == 1)//Agent is full
            {
                //move agent to container
                S1.DestinyAgent = "CS";
                Agent.MoveAgent(array2D, S1);
                Print2DArray(array2D);
                //the agent finished its work and go out
                array2D[S1.Local.Item1, S1.Local.Item2] = "CS";
            }

            Console.WriteLine("Coluna: " + S2.Local.Item1 + " Linha: " + S2.Local.Item2 + " = " + S2.Type);
            Agent.MoveAgent(array2D, S2);
            Print2DArray(array2D);
            element = garbages.Find(x => x.Local.Item1 == S2.Local.Item1 && x.Local.Item2 == S2.Local.Item2);
            result = Agent.RemoveGarbage(S2, element, array2D);
            while (result == 0)//Agent is not full
            {
                Agent.MoveAgent(array2D, S2);
                Print2DArray(array2D);
                element = garbages.Find(x => x.Local.Item1 == S2.Local.Item1 && x.Local.Item2 == S2.Local.Item2);
                result = Agent.RemoveGarbage(S2, element, array2D);
            }
            if (result == 1)//Agent is full
            {
                //move agent to container
                S2.DestinyAgent = "CS";
                Agent.MoveAgent(array2D, S2);
                Print2DArray(array2D);
                //the agent finished its work and go out
                array2D[S2.Local.Item1, S2.Local.Item2] = "CS";
            }

            Console.WriteLine("Coluna: " + S3.Local.Item1 + " Linha: " + S3.Local.Item2 + " = " + S3.Type);
            Agent.MoveAgent(array2D, S3);
            Print2DArray(array2D);
            element = garbages.Find(x => x.Local.Item1 == S3.Local.Item1 && x.Local.Item2 == S3.Local.Item2);
            result = Agent.RemoveGarbage(S3, element, array2D);
            while (result == 0)//Agent is not full
            {
                Agent.MoveAgent(array2D, S3);
                Print2DArray(array2D);
                element = garbages.Find(x => x.Local.Item1 == S3.Local.Item1 && x.Local.Item2 == S3.Local.Item2);
                result = Agent.RemoveGarbage(S3, element, array2D);
            }
            if (result == 1)//Agent is full
            {
                //move agent to container
                S3.DestinyAgent = "CS";
                Agent.MoveAgent(array2D, S3);
                Print2DArray(array2D);
                //the agent finished its work and go out
                array2D[S3.Local.Item1, S3.Local.Item2] = "CS";
            }

            Print2DArray(array2D);
            #endregion
            #endregion
        }

        public static void Initialize2DArray(String[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = "0";
                }
            }
        }

        public static void Print2DArray<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void CreateBuilding(String[,] matrix, int x, int y)
        {
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y + 3; j++)
                {
                    matrix[i, j] = "PR";
                }
            }
        }

        public static Tuple<int, int> CreateRandomPoint(String[,] matrix)
        {
            String random = "start";
            int row = 0, column = 0;
            Random rnd = new Random();
            while (random == "start" || random != "0")
            {
                row = rnd.Next(matrix.GetLength(0));
                column = rnd.Next(matrix.GetLength(1));

                random = matrix[row, column];
            }
            return Tuple.Create(row, column);
        }
    }
}
