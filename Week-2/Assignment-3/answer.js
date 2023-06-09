function count(input) {
// your code here
  let result = {}
  for (let i = 0; i < input.length; i++) {
    const item = input[i]
    if (result[item]) {
      result[item] += 1
    } else {
      result[item] = 1
    }
  }
  return result
}
let input1 = ["a", "b", "c", "a", "c", "a", "x"];
console.log(count(input1));
// should print {a:3, b:1, c:2, x:1}
function groupByKey(input) {
// your code here
  let result = {}
  for (let i = 0; i < input.length; i++) {
    const item = input[i]
    const { key, value } = item
    if (key in result) {
      result[key] += value
    } else {
      result[key] = value
    }
  }
  return result
}
let input2 = [
{ key: "a", value: 3 },
{ key: "b", value: 1 },
{ key: "c", value: 2 },
{ key: "a", value: 3 },
{ key: "c", value: 5 },
];
console.log(groupByKey(input2));
// should print {a:6, b:1, c:7}