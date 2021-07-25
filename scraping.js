const got = require('got');
const cheerio = require('cheerio');

const extractLinks = async (url) => {
  try {
    const response = await got(url);
    const html = response.body;
    const $ = cheerio.load(html);

    const linkObjects = $('a');
    const links = [];
    linkObjects.each((index, element) => {
		
		if($(element).attr('href').startsWith('/')){
			links.push({
        href: 'https://ilafe.com'+$(element).attr('href'),
      });
		}
    });
    console.log(links);
  } catch (error) {
    console.log(error.response.body);
  }
};
const URL = 'https://ilafe.com/';
extractLinks(URL);