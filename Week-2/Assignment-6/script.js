const $welcomeBlock = $('.welcome')
const $btnToggle = $('.btn-show')

$welcomeBlock.on('click', () => {
  const $msg = $('.welcome h1')
  if (!$msg.hasClass('changed')) {
    $msg.addClass('changed')
    $msg.text('Have a Good Time!')
  } else {
    $msg.removeClass()
    $msg.text('Welcome Message')
  }
})

$btnToggle.on('click', () => {
  const $addBoxes = $('.container2')
  $addBoxes.toggle()
})