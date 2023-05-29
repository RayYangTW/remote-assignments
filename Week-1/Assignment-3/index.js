function countAandB(input) {
// your code here
  let result = 0
  for(let i = 0; i < input.length; i++) {
    if (input[i] === 'a' || input[i] === 'b') {
      result ++
    }
  }
  return result
}
function toNumber(input) {
// your code here
  const letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
  let result = []
  for(let i = 0; i < input.length; i++) {
    const index = letters.indexOf(input[i])
    result.push(index + 1)
  }
  return result
}
let input1 = ['a', 'b', 'c', 'a', 'c', 'a', 'c'];
console.log(countAandB(input1)); // should print 4 (3 ‘a’ letters and 1 ‘b’ letter)
console.log(toNumber(input1)); // should print [1, 2, 3, 1, 3, 1, 3]
let input2 = ['e', 'd', 'c', 'd', 'e'];
console.log(countAandB(input2)); // should print 0
console.log(toNumber(input2)); // should print [5, 4, 3, 4, 5]