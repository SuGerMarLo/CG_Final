# CG_Final
 
These are the textures I used online and their sources.

https://orig00.deviantart.net/a7c0/f/2015/013/d/c/lava_texture_by_beijing54-d8dqux9.jpg
![Lava](https://user-images.githubusercontent.com/116387786/233704189-dc1be0f9-e001-4cf2-9948-8c9419fdb31d.jpg)

https://www.trsearch.org/images/items/Sabatu/Sabatu_SimpleLavaTexture512x512Pixels.png
![Lava2](https://user-images.githubusercontent.com/116387786/233704233-7729ecea-0b45-434b-b50c-c90b795a1224.png)

https://steamusercontent-a.akamaihd.net/ugc/2429005285070992894/65B32CF6DE5AC0F07A4AEC3539FF5BB7E3B093B0/
![BG](https://user-images.githubusercontent.com/116387786/233704273-dacdf3b3-f796-47ea-bb53-801511b5811e.png)


I was tasked with doing the even number scene.

##Lava

I started off with the lava scrolling texture.

The shader I took from the lecture was the basic scrolling texture shader, I then decided to combine it with the water shader to make it look like real lava/fire as well as to give it some depth.

![image](https://user-images.githubusercontent.com/116387786/233704530-064287a4-f2f8-4b44-90fc-4602f62a88fd.png)

The top properties are for the scrolling texture while the bottom ones are for the water shader.

![image](https://user-images.githubusercontent.com/116387786/233704851-b2553f4c-a836-4d33-a0b0-7a337d4fafdc.png)

I made sure to add the vertex portion to be able to include the water shader vertex displacement effect.

![image](https://user-images.githubusercontent.com/116387786/233704947-f2ce276b-fcbc-4117-8823-52580939e423.png)

The rest was fairly easy, as all I had to do was to put the scrolling text shader into the surf shader method, and the water shader into the vert method.

![image](https://user-images.githubusercontent.com/116387786/233705082-d7e93de0-9406-4d8a-8323-4c14199d3aa9.png)

As the final step, I created the "LavaSwitch" script, which switches the speed of the lava scrolling texture.
The toggle for this one if the "P" key (press the key twice for the effect to show up the first time, not sure why this happens but I tried fixing it by switching the bool's parity, didn't work).

![image](https://user-images.githubusercontent.com/116387786/233706491-4c25612f-90d6-4e42-ab87-33a769a9f46b.png)



##Bump

![image](https://user-images.githubusercontent.com/116387786/233705648-28f49c8f-65c9-4d0b-a750-4b238105a67b.png)

This one was also fairly simple, as the main change I did to the Bump shader code was simply add a color to it.
I decided to do this and not something else because the lava/fire acts like a light source, meaning that the background would naturally have a red tint to it (this can be modified via the inspector.

![image](https://user-images.githubusercontent.com/116387786/233705910-5f430635-4979-405c-8058-75b889797525.png)
