using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{

    public class Point:IComparable<Point>
    {

        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public string City { get; set; }
     
        public Point(int x1,int y1,int x2,int y2,string city)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            City = city;
        }
        public  int CompareTo(Point p)
        {
          
            int d1 = (this.X1 - this.X2) * (this.X1 - this.X2) + (this.Y1 - this.Y2) * (this.Y1 - this.Y2);

            int d2 = (p.X1 - p.X2) * (p.X1 - p.X2) + (p.Y1 - p.Y2) * (p.Y1 - p.Y2);

            return d1 - d2;



        }
    }
    public class NearestCity
    {
        // Input:

        //numOfPoints = 3

        //points = ["p1","p2","p3"]

        //        xCoordinates = [30, 20, 10]

        //        yCoordinates = [30, 20, 30]

        //        numOfQueriedPoints = 3

        //queriedPoints = ["p3", "p2", "p1"]

        //        Output:

        //["p1", NONE, "p3"]


        public static string[] findNearestCities()
        {

            int numOfCities = 3;
            string[] cities= new String[] { "c1", "c2", "c3" };
            Dictionary<string, int> cityDict = new Dictionary<string, int>();

            Dictionary<int, List<string>> xDict = new Dictionary<int, List<string>>();
            Dictionary<int, List<string>> yDict = new Dictionary<int, List<string>>();

            int[] xCoordinates = new int[] { 3, 2, 1  };
            int[] yCoordinates = new int[] { 3, 2, 3 };
            string[] queries = new string[] { "c1", "c2", "c3" };

            string[] result = new string[3];

            for(int i=0;i< numOfCities;i++)
            {
                cityDict.Add(cities[i], i);

                if(!xDict.ContainsKey(xCoordinates[i]))
                {
                    xDict.Add(xCoordinates[i], new List<string>());
                }
                xDict[xCoordinates[i]].Add(cities[i]);

                if (!yDict.ContainsKey(yCoordinates[i]))
                {
                    yDict.Add(yCoordinates[i], new List<string>());
                }
                yDict[yCoordinates[i]].Add(cities[i]);
            }
            List<string> neighbours = null;
           
            for(int i=0;i<queries.Length;i++)
            {
                List<Point> points = new List<Point>();
                string city= queries[i];


                int queryCityIndex = cityDict[city];
                int queryCityX = xCoordinates[queryCityIndex];
                int queryCityY = yCoordinates[queryCityIndex];

                if(xDict.ContainsKey(queryCityX))
                {
                    neighbours = xDict[queryCityX].ToList();
                    neighbours.Remove(city);
                }

                if (yDict.ContainsKey(queryCityY))
                {
                    var l = yDict[queryCityY].ToList();
                    l.Remove(city);
                    neighbours.AddRange(l);
                }

                if (neighbours.Count == 0)
                {
                    result[i] = "NONE";
                    continue;
                }

                Point point = null;

                foreach (var ne in neighbours)
                {
                    int neCityX = xCoordinates[cityDict[ne]];
                    int neCityY = yCoordinates[cityDict[ne]];
                    var p = new Point(queryCityX, queryCityY, neCityX, neCityY, ne);
                    if (point == null)
                        point = p;
                    else if (point.CompareTo(p) > 0)
                        point = p;
             
                }
                result[i] = point.City;
            }

            return result;
        }


    }
}
