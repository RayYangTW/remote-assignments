function calculation() {
  const number = document.querySelector('#input').value
  const content = document.querySelector('.container')
  const url = `/data?number=${number}`
  const xhttp = new XMLHttpRequest()
  xhttp.onreadystatechange = function() {
    if (this.readyState === 4 && this.status === 200) {
      const response = this.responseText
      if(!isNaN(Number(response))) {
        content.innerHTML = `<p>This calculation result is: <strong>${response}</strong></p>`
      } else {
        content.innerHTML = `<p>${response}</p>`
      }
    } else {
      content.innerHTML = `<p>Error! status code: <strong>${this.status}</strong></p>`
    }
  }
  xhttp.open("GET", url, true)
  xhttp.send()  
}