const welcome = document.querySelector('.welcome')
const btnToggle = document.querySelector('.btn-show')

welcome.addEventListener('click', () => {
  const msg = document.querySelector('.welcome h1')
  if (!msg.className) {
    msg.className = 'changed'
    msg.textContent = 'Have a Good Time!'
  } else if ( msg.className === 'changed') {
    msg.classList.remove('changed')
    msg.textContent = 'Welcome Message'
  } else {
    msg.textContent = 'Welcome Message'
  }
})
 btnToggle.addEventListener('click', () => {
  const toShowBoxes = document.querySelector('.container2')
  if (toShowBoxes.style.display === 'none') {
    toShowBoxes.removeAttribute('style') 
  } else {
    toShowBoxes.style.display = 'none'
  }
})