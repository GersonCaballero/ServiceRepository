import { ConsultarteTemplatePage } from './app.po';

describe('Consultarte App', function() {
  let page: ConsultarteTemplatePage;

  beforeEach(() => {
    page = new ConsultarteTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
