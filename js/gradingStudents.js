const gradeStudent = (grade) =>
    grade < 38 || grade % 5 == 0 || grade % 5 < 3 ? grade : 
    grade % 5 > 2 ? grade + (5- (grade % 5)):
    0;

let fg = [73, 67, 38, 33].map(gradeStudent);
console.log(fg);
