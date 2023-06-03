function avg(data) {
// your code here
  let totalPrice = 0
  let index = data.products.length
  for ( let i = 0; i < data.products.length; i++ ) {
    totalPrice += data.products[i].price
  }
  return totalPrice / index
}
console.log(
  avg({
    size: 3,
    products: [
      {
        name: 'Product 1',
        price: 100,
      },
      {
        name: 'Product 2',
        price: 700,
      },
      {
        name: 'Product 3',
        price: 250,
      },
    ],
})
); // should print the average price of all products