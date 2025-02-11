static List<int> gradingStudents(List<int> grades)
{
    List<int> finalgrades = new List<int>();
    foreach (int grade in grades)
        if(grade < 38 || grade % 5 == 0 || grade % 5 < 3)
            finalgrades.Add(grade);
        else if(grade % 5 > 2)
            finalgrades.Add(grade + (5- (grade % 5)));
    
    return finalgrades;
}

List<int> g = new List<int>(new int[] { 73, 67, 38, 33 } );
var fg = gradingStudents(g);

Console.Write(string.Join(" ", fg));