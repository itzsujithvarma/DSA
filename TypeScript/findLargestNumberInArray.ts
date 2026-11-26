function findLargestNumberInArray(num: number[]){
let max: number = num[0];
for(let i = 1;i<num.length;i++) {
    if(num[i]>max) max=num[i];
}
console.log(`The largest number in array is ${max}`);
}

findLargestNumberInArray([34,54,78,12,1]);