'use strict'
function solve (args) {
  let number = +args

  if (number % 2) {
    console.log('odd ' + number)
  } else {
    console.log('even ' + number)
  }
}

solve('5')
solve('6')
solve('0')
solve('-5')
solve('-6')
