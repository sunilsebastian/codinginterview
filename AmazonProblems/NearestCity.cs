using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    //O(n*m)  nis the number of query  cities and m is the neighbouring cities

    //Space complexity : O(n) is the number of cities
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

            return (d1==d2)?this.City.CompareTo(p.City):d1-d2;

        }
    }
    public class NearestCity
    {
    
        public static string[] findNearestCities()
        {
            //int numOfCities = 4;
            //string[] cities = new String[] { "c1", "c2", "c3", "c4" };
            //int[] xCoordinates = new int[] { 1, 1, 1, 1 };
            //int[] yCoordinates = new int[] { 1, 2, 3, 4 };
            //string[] queries = new string[] { "c1", "c2", "c3", "c4" };

            //int numOfCities = 3;
            //string[] cities = { "p1", "p2", "p3" };
            //int[] xCoordinates = { 3, 2, 1 };
            //int[] yCoordinates = { 3, 2, 3 };
            //string[] queries = new string[] { "p1", "p2", "p3" };

            //int numOfCities = 5;
            //string[] cities = { "green", "red", "blue", "yellow", "pink" };
            //int[] xCoordinates = {100,200,300,400,500 };
            //int[] yCoordinates = {100,200,300,400,500};
            //string[] queries = new string[] { "green", "red", "blue", "yellow", "pink" };

            //int numOfCities = 5;
            //string[] cities = { "green", "red", "blue", "yellow", "pink" };
            //int[] xCoordinates = {100,200,300,400,500 };
            //int[] yCoordinates = {100,200,300,400,500};
            //string[] queries = new string[] { "green", "red", "blue", "yellow", "pink" };

            //int numOfCities =5;
            //string[] cities = { "a1", "a2", "b1", "b2", "c2" };
            //int[] xCoordinates = { 6 ,5 ,8 ,6, 10 };
            //int[] yCoordinates = { 1,2,3,4,5};
            //string[] queries = new string[] { "a1", "a2", "b1", "b2", "c2" };

            //int numOfCities = 5;
            //string[] cities = { "a", "b", "c", "d", "e" };
            //int[] xCoordinates = {50,60,100,200,300 };
            //int[] yCoordinates = {50,60,50,200,50};
            //string[] queries = new string[] { "a", "b", "c", "d", "e" };

            //int numOfCities = 5;
            //string[] cities = { "loc1", "loc2", "loc3", "loc4", "loc5" };
            //int[] xCoordinates = { 3, 2, 1, 4, 5 };
            //int[] yCoordinates = { 2, 1, 4, 3, 5 };
            //string[] queries = new string[] { "loc1", "loc2", "loc3", "loc4", "loc5" };

            //int numOfCities = 5;
            //string[] cities = { "loc1", "loc2", "loc3", "loc4", "loc5" };
            //int[] xCoordinates = { 3,3,3,3,3};
            //int[] yCoordinates = { 1,2,3,4,5};
            //string[] queries = new string[] { "loc1", "loc2", "loc3", "loc4", "loc5" };

            int numOfCities = 5;
            string[] cities = { "loc1", "loc2", "loc3", "loc4", "loc5" };
            int[] xCoordinates = { 5,10,2,5,10 };
            int[] yCoordinates = {10,1,5,1,1};
            string[] queries = new string[] { "loc1", "loc2", "loc3", "loc4", "loc5" };

           

            Dictionary<string, int> cityDict = new Dictionary<string, int>();

            Dictionary<int, List<string>> xDict = new Dictionary<int, List<string>>();
            Dictionary<int, List<string>> yDict = new Dictionary<int, List<string>>();

           

            string[] result = new string[queries.Length];

            for(int i=0;i< numOfCities;i++)
            {
                //contain city and array  index  
                cityDict.Add(cities[i], i);

                
                // x-cordinate and all cities which has this particular x-coordinate
                if(!xDict.ContainsKey(xCoordinates[i]))
                {
                    xDict.Add(xCoordinates[i], new List<string>());
                }
                xDict[xCoordinates[i]].Add(cities[i]);


                //y-cordinate and all cities which has this particular y-cordinate
                if (!yDict.ContainsKey(yCoordinates[i]))
                {
                    yDict.Add(yCoordinates[i], new List<string>());
                }
                yDict[yCoordinates[i]].Add(cities[i]);
            }

            //Hold the neighbours of querying city
            List<string> neighbours = null;
           
            //Go though the cities where we want to find the closest neighbour
            for(int i=0;i<queries.Length;i++)
            {
                List<Point> points = new List<Point>();
                string city= queries[i];

                //find query cit's index and  x-cor and y-cord of the city
                int queryCityIndex = cityDict[city];
                int queryCityX = xCoordinates[queryCityIndex];
                int queryCityY = yCoordinates[queryCityIndex];

                //find the neigbours of query city by matching X-cord
                if(xDict.ContainsKey(queryCityX))
                {
                    neighbours = xDict[queryCityX].ToList();
                    neighbours.Remove(city);
                }

                //find the neigbours of query city by matching X-cord
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
                //find the closest neighbour to the querycity
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
                result[i] = point?.City;
            }

            return result;
        }


    }
}
