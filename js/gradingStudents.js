/*function gradingStudents(grades) {
    let finalgrades = [];
    grades.forEach(grade => {        
        if(grade < 38 || grade % 5 == 0 || grade % 5 < 3)
            finalgrades.push(grade);
        else if(grade % 5 > 2)
            finalgrades.push(grade + (5- (grade % 5)));
    });
    return finalgrades;
}*/

const gradeStudent = (grade) =>
    grade < 38 || grade % 5 == 0 || grade % 5 < 3 ? grade : 
    grade % 5 > 2 ? grade + (5- (grade % 5)):
    0;

let fg = [73, 67, 38, 33].map(gradeStudent);
console.log(fg);
