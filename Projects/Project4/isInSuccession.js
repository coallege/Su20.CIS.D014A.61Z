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
      if (ary[i - 1] + 1 !== ary[i]) {
         return false;
      }
   }
   return true;
}

/** @param {number[]} ary */
const isInSuccession4 = ary => ary.every((v, i, self) => v + 1 === (self[i + 1] || v + 1));

const sub = (a,b) => a-b;
const equals = a => b => a == b;
const isInSuccession5 = ary => ary.map(sub).every(equals(ary[0]));

const isInSuccession6=A=>A.map((a,b)=>a-b).every(a=>a===A[0]);
const isInSuccession7=a=>!a.some((b,c)=>b-c^a[0]);

module.exports = {
   isInSuccession1,
   isInSuccession2,
   isInSuccession3,
   isInSuccession4,
   isInSuccession5,
   isInSuccession6,
   isInSuccession7,
};
