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
    public partial class Bai3 : ContentPage
    {
        public Bai3()
        {
            InitializeComponent();
            KhoiTaoListAnimal();
        }
        List<Animal> animals = new List<Animal>();

        private void KhoiTaoListAnimal()
        {
            animals.Add(new Animal { animalname="Chim cánh cụt", animalcode = 1, animalimage="penguin.jpg",animaldes= "Chim cánh cụt hay còn gọi là chim cụt cánh là một nhóm chim nước không bay được. Chúng hầu như chỉ sống ở Nam bán cầu, với duy nhất một loài, chim cánh cụt Galápagos, được tìm thấy ở phía bắc đường xích đạo." });
            animals.Add(new Animal { animalname="Hải cẩu",animalcode = 2, animalimage = "seal.jpg", animaldes = "Họ Hải cẩu thật sự, hay còn gọi là họ Chó biển, hoặc hải cẩu không vành tai là một trong ba nhóm động vật có vú chính của nhánh động vật chân màng, Phân bộ Dạng chó, Bộ Ăn thịt." });
            animals.Add(new Animal { animalname="Chó",animalcode = 3, animalimage = "dog.jpg", animaldes = "Chó, là một loài động vật thuộc chi Chó, tạo nên một phần tiến hóa của sói, đồng thời là loài động vật ăn thịt trên cạn có số lượng lớn nhất." });
            animals.Add(new Animal { animalname="Mèo",animalcode = 4, animalimage = "cat.jpg", animaldes = "Mèo là động vật có vú, nhỏ nhắn và chuyên ăn thịt, sống chung với loài người, được nuôi để săn vật gây hại hoặc làm thú nuôi cùng với chó nhà. Mèo nhà đã sống gần gũi với loài người ít nhất 9.500 năm, và hiện nay chúng là con vật cưng phổ biến nhất trên thế giới." });
            listAnimal.ItemsSource = animals;   
        }

        private void listAnimal_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (sender != null)
            {
                Animal animal = (Animal)listAnimal.SelectedItem;
                Navigation.PushAsync(new PageIndividualAnimal(animal));
            }
        }
    }
}