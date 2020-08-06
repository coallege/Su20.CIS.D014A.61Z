const test = require("ava").default;

const succ = require("./isInSuccession");

function testFn(fn, v) {
   const o_ary0 = [1, 2, 3, 4, 5];
   const o_ary1 = [4, 5, 6, 7, 8, 9];
   const o_ary2 = [1, 2];
   const o_ary3 = [2, 3];
   test(`${v}: arrays in order are true`, t => {
      t.is(fn(o_ary0), true);
      t.is(fn(o_ary1), true);
      t.is(fn(o_ary2), true);
      t.is(fn(o_ary3), true);
    });

   const u_ary0 = [1, 3, 4, 5, 6];
   const u_ary1 = [0, 1, 3, 4, 5];
   const u_ary2 = [3, 5];
   test(`${v}: arrays not in order are false`, t => {
      t.is(fn(u_ary0), false);
      t.is(fn(u_ary1), false);
      t.is(fn(u_ary2), false);
   });
}

testFn(succ.isInSuccession1, "1");
// testFn(succ.isInSuccession2, "2"); // broken
testFn(succ.isInSuccession3, "3");
testFn(succ.isInSuccession4, "4");
testFn(succ.isInSuccession5, "5");
testFn(succ.isInSuccession6, "6");
testFn(succ.isInSuccession7, "7");
