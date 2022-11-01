//Task-3: Ədədlərdən ibarət olan bir array verilib həmin arraydə olan ən böyük ədədi ekrana yazdıran alqoritm yazın.
let ourArray = [-17,-11,-3,-6,-5];
let maxNumber = ourArray[0];
for(let i=1;i<ourArray.length;i++){
   if(ourArray[i]>maxNumber){
    maxNumber = ourArray[i];}
}
console.log(maxNumber);