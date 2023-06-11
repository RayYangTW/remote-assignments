function calculation() {
  const number = document.querySelector('#input').value
  const url = `/data?number=${number}`
  const xhttp = new XMLHttpRequest()
  xhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
        location.href= url
      } else {
        location.href= url
        console.error('Error: ' + this.status)
      }
    }
  xhttp.open("GET", url, true)
  xhttp.send()  
}