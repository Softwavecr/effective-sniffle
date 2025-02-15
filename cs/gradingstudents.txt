static List<int> gradingStudents(List<int> grades)
{
    var finalgrades = new List<int>();
    foreach (int grade in grades)
        if(grade < 38 || grade % 5 == 0 || grade % 5 < 3)
            finalgrades.Add(grade);
        else if(grade % 5 > 2)
            finalgrades.Add(grade + (5- (grade % 5)));
    
    return finalgrades;
}

var fg = gradingStudents(new List<int>(){ 73, 67, 38, 33 } );
Console.WriteLine(string.Join(" ", fg));