console.log(
   [...$0.querySelector("code").children]
      .map(n => n.innerText)
      .join('\n')
      .replace(/−/, '-')
      .replace(/\.{3}/g, ""))
// you need to select the <pre> tag that you want to copy text from
