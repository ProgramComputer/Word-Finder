using System;
using System.Collections.Generic;
using System.Linq;
public class start
{
    static void Main()
    {
    var dictionary = new string[] { "chill", "wind", "snow", "cold" };
    var src = new string[] { "abcdc", "fgwio", "chill", "pqnsd", "uvdxy" };
    var result = new WordFinder( dictionary ).Find( src );
    foreach( string show in result)
    {
        Console.WriteLine(show);
    }
    }


}



   public class WordFinder
   {
    
     
       IEnumerable<string> dictionary;
       public WordFinder(IEnumerable<string> dictionary)
       {
           this.dictionary = dictionary;
       }
       public IList<string> Find( IEnumerable<string> src)
       {
           List<string> results = new List<string>();
           
           foreach(string key in dictionary)
           {
               string[] iterateArray = {};
               Dictionary<int, string> found = new Dictionary<int, string>();
                iterateArray = src.ToArray();
                    
                   for( int i = 0; i < iterateArray.Length; ++i)
                   {
                       
                       List<char> charArray = new List<char>();
                        charArray.AddRange(iterateArray[i]);
                   if(iterateArray[i].Contains(key))
                   {
                         
                       results.Add(key);
                       break;
                       
                   }
                   for(int j = 0; j < charArray.Count; ++j)
                    {
                        
                       if(key.Contains(charArray[j]))
                        {
                            
                            if (found.ContainsKey(j)) 
                            { 
                               
                            found[j] += charArray[j].ToString();
            
                            charArray.RemoveRange(0, j);
                            
                           
                            }
                            else
                            {
                               found[j]  = charArray[j].ToString();
                               charArray.RemoveRange(0, j);
                            
                            }
                
                      
                      
                       
                        
                        }
                       
                       
                    }
                     
                  

                    
               }
              
foreach(KeyValuePair<int, string> entry in found)
{

    if(!results.Contains(key)&&key.Contains(entry.Value))
    {
        results.Add(key);
        
    }
}
              
            }
           
            return results;
           
           
           
           }
          



        }

