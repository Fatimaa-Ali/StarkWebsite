const header = document.querySelector("header");
const hamburgerBtn = document.querySelector("#menu-btn");
const closeMenuBtn = document.querySelector(".close-btn");

// Toggle mobile menu on hamburger button click
hamburgerBtn.addEventListener("click", () => header.classList.toggle("show-mobile-menu"));

// Close mobile menu on close button click
closeMenuBtn.addEventListener("click", () => header.classList.remove("show-mobile-menu"));



function toggleMegaBox() {
    var megaBox = document.querySelector('.mega-box-clickable');
    megaBox.classList.toggle('active');
  }

  // Get the button element
  const exploreButton = document.querySelector('.explore-button');

  // Add event listener for click event
  exploreButton.addEventListener('click', function() {
    // Replace this with the action you want to perform when the button is clicked
    console.log('Button clicked!');
    // For example, you can navigate to another page:
    // window.location.href = 'https://example.com';
  });
  
  