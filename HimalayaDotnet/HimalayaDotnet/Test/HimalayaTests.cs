using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HimalayaDotnet.Test
{
    public class HimalayaTests
    {
        private string _testDoc = @"[{
              type: 'element',
              tagName: 'div',
              attributes: [{
                key: 'class',
                value: 'post post-featured'
              }],
              children: [{
                type: 'element',
                tagName: 'p',
                attributes: [],
                children: [{
                  type: 'text',
                  content: 'Himalaya parsed me...'
                }]
              }, {
                type: 'comment',
                content: ' ...and I liked it. '
              }]
            }]";

        [Fact]
        public void ParseJsonTest()
        {
            var elements = HimalayaElement.ParseJson(_testDoc);
            Assert.Single(elements);
            var element = elements[0];
            Assert.Equal("element", element.Type);
            Assert.Equal("div", element.TagName);
            Assert.Single(element.Attributes);
            var attr = element.Attributes[0];
            Assert.Equal("class", attr.Key);
            Assert.Equal(2, element.Children.Count);
            var child = element.Children[0];
            Assert.Equal("element", child.Type);
            Assert.Equal("p", child.TagName);
        }
    }
}
