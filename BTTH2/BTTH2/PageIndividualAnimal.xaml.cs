using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageIndividualAnimal : ContentPage
    {
        public PageIndividualAnimal(Animal animal)
        {
            InitializeComponent();
            KhoiTaoListCaThe(animal);
        }
        List<IndividualAnimal> IAnimals = new List<IndividualAnimal>();
        private void KhoiTaoListCaThe(Animal animal)
        {
            if (animal.animalcode == 1)
            {
                IAnimals.Add(new IndividualAnimal { individualimage="hoangde.jpg", individualname="Chim cánh cụt hoàng đế", individualdes= "Chim cánh cụt hoàng đế là một loài chim trong họ Spheniscidae. Chúng là loại chim lớn nhất và nặng nhất trong số tất cả những loài chim cánh cụt sống và đặc hữu ở Châu Nam Cực.", individualcode=1});
                IAnimals.Add(new IndividualAnimal { individualimage = "galapagos.jpg", individualname = "Chim cánh cụt Galápagos", individualdes = "Chim cánh cụt Galápagos là một loài chim trong họ Spheniscidae. Đây là một loài chim cánh cụt loài đặc hữu của quần đảo Galapagos", individualcode=2 });
                IAnimals.Add(new IndividualAnimal { individualimage = "adelie.jpg", individualname = "Chim cánh cụt Adélie", individualdes = "Chim cánh cụt Adélie là một loài chim trong họ Spheniscidae. Chúng là loài chim cánh cụt phổ biến dọc theo toàn bộ bờ biển Nam Cực.", individualcode=3 });


            }
            else if (animal.animalcode == 2)
            {
                IAnimals.Add(new IndividualAnimal { individualimage = "cangbien.jpg", individualname = "Hải cẩu cảng biển", individualdes = "Hải cẩu cảng biển là một loài động vật có vú trong họ Hải cẩu thật sự, bộ Ăn thịt. Loài hải cẩu này được tìm thấy dọc theo biển ôn đới và bờ biển Bắc Cực tại Bắc bán cầu", individualcode = 4 });
                IAnimals.Add(new IndividualAnimal { individualimage = "xam.jpg", individualname = "Hải cẩu xám", individualdes = "Hải cẩu xám là một loài động vật có vú trong họ Hải cẩu thật sự, bộ Ăn thịt. Loài hải cẩu này được Fabricius mô tả năm 1791. Đây là loài duy nhất trong chi. ", individualcode = 5 });
                IAnimals.Add(new IndividualAnimal { individualimage = "greenland.jpg", individualname = "Hải cẩu Greenland", individualdes = "Hải cẩu Greenland, Hải cẩu đàn hạc hay Hải cẩu hạc cầm, Hải cẩu lưng yên ngựa là một loài động vật có vú trong họ Hải cẩu thật sự, bộ Ăn thịt. Loài này được Erxleben mô tả năm 1777. Loài hải cẩu này là loài bản địa từ phía bắc Đại Tây Dương và các khu vực của Bắc Băng Dương.", individualcode = 6 });

            }
            else if (animal.animalcode == 3)
            {
                IAnimals.Add(new IndividualAnimal { individualimage = "labradoe.jpg", individualname = "Chó tha mồi Labrador", individualdes = "Chó tha mồi Labrador thường được gọi với tên thân thuộc là Lab là một giống chó săn phổ biến ở Mỹ chúng thuộc nhóm chó săn mồi và thường dùng để tha các con mồi về cho chủ trong các cuộc săn.", individualcode = 7 });
                IAnimals.Add(new IndividualAnimal { individualimage = "beccgie.jpg", individualname = "Chó chăn cừu Đức", individualdes = "Chó chăn cừu Đức, là một giống chó kích cỡ lớn, xuất xứ từ Đức. Tại Việt Nam, giống chó này được gọi là chó Berger, phiên âm từ tiếng Pháp berger cũng có nghĩa là chó chăn cừu. Chó chăn cừu Đức là một giống chó tương đối mới, từ năm 1899. ", individualcode = 8 });
                IAnimals.Add(new IndividualAnimal { individualimage = "doberman.jpg", individualname = "Dobermann", individualdes = "Doberman là một giống chó có thể nuôi để giữ nhà, canh gác hoặc làm nghiệp vụ. Tên gọi đầy đủ và chính xác của nó là Dobermann Pinscher. Dobermann là một trong số ít những loại chó được đặt theo tên người. Đây là một giống chó hung dữ, nhưng nếu được đào tạo tốt, nó có thể là những con chó tuyệt vời của gia đình. ", individualcode = 9 });

            }
            else if (animal.animalcode == 4)
            {
                IAnimals.Add(new IndividualAnimal { individualimage = "longngananh.jpg", individualname = "Mèo lông ngắn Anh", individualdes = "Mèo lông ngắn Anh là phiên bản nhân giống có chọn lọc của mèo nhà Anh truyền thống với những đặc điểm như thân hình mũm mĩm, lông ngắn và dày cùng với khuôn mặt to. Màu sắc phổ biến nhất là màu xám xanh với mắt màu vàng đồng, nhưng ngoài ra vẫn còn nhiều màu sắc và hoa văn khác nhau.", individualcode = 10 });
                IAnimals.Add(new IndividualAnimal { individualimage = "batu.jpg", individualname = "Mèo Ba Tư", individualdes = "Mèo Ba Tư hay còn gọi là mèo Ba Tư mặt tịt là một giống mèo có nguồn gốc từ Ba Tư", individualcode = 11});
                IAnimals.Add(new IndividualAnimal { individualimage = "ragdoll.jpg", individualname = "Mèo Ragdoll", individualdes = "Ragdoll là một giống mèo với đôi mắt màu xanh dương và bộ lông hai màu tương phản đặc trưng. Nó là giống mèo to lớn, với cơ bắp rắn chắc và bộ lông mềm mại và hơi dài Chúng cũng được biết đến là giống mèo hiền lành và dễ bảo.", individualcode = 12 });


            }
            listIndividualAnimals.ItemsSource = IAnimals;
        }
        private void listIndividualAnimals_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

    }
}