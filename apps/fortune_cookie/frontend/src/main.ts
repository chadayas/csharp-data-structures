import './style.css'

interface FortuneDto{
   sentence: string;
}

async function getFortune(): Promise<FortuneDto>{
   const res = await fetch("http://localhost:5196/api/fortune");
   
   if(!res.ok){
      throw new Error("Problem with fetch: ${res.status}");
   }

   const fortune: FortuneDto = await res.json();
   return fortune;
}


document.querySelector<HTMLDivElement>('#app')!.innerHTML = `
<section id="center">
  <div class="hero">
  </div>
  <div>
    <h1>Click for your fortune</h1>
    <button id="open-cookie" type="submit">Get Fortune</button>
    <p id="fortune">Fortune appears here</p>
 </div>
</section>
`
const button = document.querySelector<HTMLButtonElement>('#open-cookie');
const show = document.querySelector<HTMLParagraphElement>('#fortune');

if(button){
   button.addEventListener("click", async () => {
      show.textContent = "Loading fortune...";  
      try{
         const fortune = await getFortune();
         show.textContent = fortune.sentence;
      }  catch {
         show.textContent = "No fortune loaded";
      }
   })
}


//document.querySelector<HTMLElement>('#app2')!.innerHTML = `
//<p id="fortune"></p>
//`
