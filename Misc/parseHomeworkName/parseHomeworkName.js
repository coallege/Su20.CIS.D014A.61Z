/** @param {string} s */
function parseHomeworkDir(s) {
   const [exChapter, section, ...steps] = s.split("_");
   const chapter = exChapter.slice(2);
   let out = `chapter ${chapter}, section ${section}`;
   if (steps.length > 0) {
      out += ", exercises ";
      switch (steps.length) {
         case 1: { out += steps[0]; break }
         case 2: { out += `${steps[0]} and ${steps[1]}`; break }
         default: { out += `${steps.slice(-1).join(", ")}, and ${steps[steps.length - 1]}` }
      }
   }
   return out;
}
