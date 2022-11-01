//Task-2: Ədədlərdən ibarət olan arraydə neçə müsbət neçə mənfi ədəd olduğunu ekrana çıxardan alqoritm yazın.

let ourArray = [1,-2,3,-4,5,-6,0];
let numberOfPositive = 0;
let numberOfNegative = 0;

for(let i=0;i<ourArray.length;i++){
    if(ourArray[i]>0){ numberOfPositive++}
    else if(ourArray[i]<0){numberOfNegative++}
}
console.log("Number of Poisitive numbers: "+ numberOfPositive);
console.log("Number of Negative numbers: "+ numberOfNegative);