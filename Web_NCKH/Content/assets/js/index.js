// Font awesome のCSS疑似要素への許可
window.FontAwesomeConfig = {
  searchPseudoElements: true
};

// Radix css の初期化、追加スクリプト
window.addEventListener('DOMContentLoaded', () => {
  let myRadix = new radix({
    toggleNav: {
      active: true,
      trigger: '#toggle-nav',
      target: '#global-nav',
      preventScroll: true
    },
    svg: {
      active: true,
      humbergerMenu: '#svg-toggle'
    }
  });
  myRadix.init();
  
  // ここから追加スクリプト
  
  
});