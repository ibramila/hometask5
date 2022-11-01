//Task-1:Ədədlərdən ibarət olan, verilmiş arrayin ədədi ortasını tapın.

let ourArray =[1,2,3,4];
let sum = 0;

for(let i=0; i<ourArray.length; i++){
    sum+=ourArray[i];
}
console.log(sum/ourArray.length);