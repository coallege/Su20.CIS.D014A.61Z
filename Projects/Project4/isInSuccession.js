// Easier to prototype code in this language

/** @param {number[]} ary */
function isInSuccession1(ary) {
   let previous = ary[0] - 1;
   return ary.every(element => previous +++ 1 === element);
}

// doesn't work
/** @param {number[]} ary */
const isInSuccession2 = ary => ary.reduce((a, v) => v === a + 1, ary[0] - 1);

/** @param {number[]} ary */
function isInSuccession3(ary) {
   for (let i = 1; i < ary.length; i++) {
      if (ary[i] !== ary[i - 1]) {
         return false;
      }
   }
   return true;
}

/**
 * @param {boolean} b
 * @param {string} msg
 */
function assert(b, name) {
   if (b) {
      console.log(`\x1b[32mPass: ${name}\x1b[0m`);
   } else {
      console.error(`\x1b[91mFail: ${name}\x1b[0m`);
   }
}

function testFn(fn, v) {
   assert(fn([1, 2, 3, 4, 5]) === true, `Test 5 digit 1.${v}`);
   assert(fn([1, 3, 4, 5, 6]) === false, `Test 5 digit 2.${v}`);
   assert(fn([0, 1, 3, 4, 5]) === false, `Test 5 digit 3.${v}`);
   assert(fn([4, 5, 6, 7, 8, 9]) === true, `Test 6 digit 4.${v}`);

   assert(fn([1, 2]) === true, `Test 2 Digit 1.${v}`);
   assert(fn([2, 3]) === true, `Test 2 Digit 1.${v}`);
   assert(fn([3, 5]) === false, `Test 2 Digit 1.${v}`);
   console.log("--------");
}

testFn(isInSuccession1, "1");
testFn(isInSuccession2, "2");
testFn(isInSuccession3, "3");

